package com.haruww.plamemokr;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.FileReader;
import java.io.IOException;
import java.io.Reader;
import java.util.ArrayList;

public class Parser
{
    public static ArrayList<String> decryptJSON(String fileName) throws IOException, ParseException
    {
        ArrayList<String> output = new ArrayList<>();
        Reader json = new FileReader(fileName);

        JSONParser jParser = new JSONParser();
        JSONObject jObject = (JSONObject) jParser.parse(json);
        JSONArray jArrayOriginal = (JSONArray) jObject.get("scenes");

        int index = 0;

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
                        .append("\"dummy").append("\",")
                        .append("\"dummy").append("\"");
                //    "인덱스" ,  "선택1"   ,   "선택2"   ,   "번역1"   ,   "번역2"

                index++;
                output.add(sb.toString());
            }
        }






        return output;
    }
}
