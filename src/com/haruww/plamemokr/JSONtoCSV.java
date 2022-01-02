package com.haruww.plamemokr;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.*;
import java.util.ArrayList;

public class JSONtoCSV
{
    private static ArrayList<String> decryptJSON(String fileName) throws IOException, ParseException
    {
        ArrayList<String> output = new ArrayList<>();
        Reader json = new FileReader(fileName);

        JSONParser jParser = new JSONParser();
        JSONObject jObject = (JSONObject) jParser.parse(json);
        JSONArray jArrayOriginal = (JSONArray) jObject.get("scenes");

        int index = 0;

        StringBuilder sb1 = new StringBuilder();
        sb1.append("\"").append("번호").append("\",")
                .append("\"").append("이름").append("\",")
                .append("\"").append("닉네임").append("\",")
                .append("\"").append("문장").append("\",")
                .append("\"").append("이름번역").append("\",")
                .append("\"").append("닉네임번역").append("\",")
                .append("\"").append("문장번역").append("\"");

        output.add(sb1.toString());

        for(int i=0; i<jArrayOriginal.size(); i++)
        {
            jObject = (JSONObject) jParser.parse(jArrayOriginal.get(i).toString());

            if(jObject.containsKey("texts"))
            {
                JSONArray jArray1 = (JSONArray) jObject.get("texts");

                for (Object a : jArray1)
                {
                    JSONArray jArray = (JSONArray) a;

                    String name;
                    String nickName;
                    String words;

                    if(jArray.get(0) == null)
                    {
                        name = "";
                    }
                    else
                    {
                        name = (String) jArray.get(0);
                    }

                    if(jArray.get(1) == null)
                    {
                        nickName = "";
                    }
                    else
                    {
                        nickName = (String) jArray.get(1);
                    }

                    words = (String) jArray.get(2);

                    StringBuilder sb = new StringBuilder();
                    sb.append("\"").append(index).append("\",")
                            .append("\"").append(name).append("\",")
                            .append("\"").append(nickName).append("\",")
                            .append("\"").append(words).append("\",")
                            .append("\"").append("\",")
                            .append("\"").append("\",")
                            .append("\"").append("\"");

                    output.add(sb.toString());
                    //    "인덱스" ,  "이름"   ,   "닉네임"   ,   "말"   ,   "번역이름"   ,   "번역닉네임"   ,   "번역말"
                    index++;
                }
            }
            else if (jObject.containsKey("selects"))
            {
                StringBuilder sb = new StringBuilder();
                ArrayList<String> choose = new ArrayList<>();

                JSONArray jArray1 = (JSONArray) jObject.get("selects");
                for (Object a : jArray1)
                {
                    JSONObject jObject1 = (JSONObject) jParser.parse(a.toString());
                    choose.add((String) jObject1.get("text"));
                }
                sb.append("\"").append(index).append("\",")
                        .append("\"").append(choose.get(0)).append("\",")
                        .append("\"").append(choose.get(1)).append("\",")
                        .append("\"").append("\",")
                        .append("\"").append("\",")
                        .append("\"dummy").append("\",")
                        .append("\"dummy").append("\"");
                //    "인덱스" ,  "선택1"   ,   "선택2"   ,   "번역1"   ,   "번역2"
                index++;
                output.add(sb.toString());
            }
        }
        return output;
    }

    public static void toCSV(String fileName) throws IOException, ParseException
    {
        ArrayList list = decryptJSON(fileName);

        String a = fileName.replace(".\\scenario_json", ".\\scenario_csv");

        File csv = new File(a + ".csv");
        createFile(csv);

        BufferedWriter bufferedWriter;

        bufferedWriter = new BufferedWriter(new FileWriter(csv));

        for (Object s : list)
        {
            bufferedWriter.write((String)s);
            bufferedWriter.newLine();
        }

        if (bufferedWriter != null)
        {
            bufferedWriter.flush();
            bufferedWriter.close();
        }
    }

    private static void createFile(File f)
    {
        try
        {
            f.createNewFile();
        } catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
