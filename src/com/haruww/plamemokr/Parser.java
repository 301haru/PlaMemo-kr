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
        JSONArray jArray = (JSONArray) jObject.get("scenes");

        jObject = (JSONObject) jParser.parse(jArray.get(0).toString());
        JSONArray jArray1 = (JSONArray) jObject.get("texts");

        int index = 0;
        for (Object a : jArray1)
        {
            jArray = (JSONArray) a;
            if(jArray.get(0) == null && jArray.get(1) == null)
            {
                output.add("\"" + index + "\"," +"\"" + jArray.get(2) + "\",\"\"");
                //System.out.println("\"" + index + "\"," +"\"" + jArray.get(2) + "\",\"\"");//0, 1은 null 2는 텍스트
                index++;
            }
        }

        return output;
    }
}
