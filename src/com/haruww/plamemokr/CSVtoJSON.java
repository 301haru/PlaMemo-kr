package com.haruww.plamemokr;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.*;
import java.util.ArrayList;
import java.util.Iterator;

public class CSVtoJSON
{
    static JSONObject jObjectTemp;

    public static void toJSON(String csvFilePath, String jsonFilePath) throws IOException, ParseException
    {
        File csv = new File(csvFilePath);

        BufferedReader br;
        br = new BufferedReader(new FileReader(csv));

        String line = "";
        String[] lines = new String[3];

        int c = 0;

        jObjectTemp = new JSONObject();

        while ((line = br.readLine()) != null)
        {
            lines[0] = line.split(",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)", -1)[3];
            lines[1] = line.split(",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)", -1)[4];
            lines[2] = line.split(",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)", -1)[5];

            encryptJSON(lines[0], lines[1], lines[2], jsonFilePath, c);

            c++; //c는 몇번째줄인지 체크하는용도
        }

        BufferedWriter bf = new BufferedWriter(new FileWriter("d:\\teasdf.json"));
        bf.write(String.valueOf(jObjectTemp));
        bf.flush();
        bf.close();
    }




    private static void encryptJSON(String nameKR, String nickNameKR, String wordsKR, String jsonFilePath, int count) throws IOException, ParseException
    {
        wordsKR = wordsKR.replaceAll("\"", "");
        nickNameKR = nickNameKR.replaceAll("\"", "");
        nameKR = nameKR.replaceAll("\"", "");

        JSONParser jParser = new JSONParser();
        Reader json = new FileReader(jsonFilePath);

        JSONObject jObject;

        if (count==0)
        {
            jObject = (JSONObject) jParser.parse(json); //최초 1회 원본 받아오기
        }
        else
        {
            jObject = (JSONObject) jParser.parse(String.valueOf(jObjectTemp));
        }

        JSONArray jArrayOriginal = (JSONArray) jObject.get("scenes"); //scenes 안

        for (int i=0; i<jArrayOriginal.size(); i++)
        {
            JSONObject jObject1 = (JSONObject) jParser.parse(jArrayOriginal.get(i).toString());

            if (jObject1.containsKey("texts"))
            {
                JSONArray jArray1 = (JSONArray) jObject1.get("texts");
                JSONArray jArray = (JSONArray) jArray1.get(count);

                if (!wordsKR.equals(""))
                {
                    jArray.set(2, wordsKR);
                    if (!nameKR.equals(""))
                    {
                        jArray.set(0, nameKR);
                        if (!nickNameKR.equals(""))
                        {
                            jArray.set(1, nickNameKR);
                        }
                    }
                    jArray1.set(count, jArray);
                    jArrayOriginal.set(i, jObject1);
                    jObject.put("scenes", jArrayOriginal);

                    jObjectTemp = jObject;
                }
            }
        }
    }
}
