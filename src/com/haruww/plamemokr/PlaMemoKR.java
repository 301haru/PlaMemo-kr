package com.haruww.plamemokr;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import java.io.FileReader;
import java.io.IOException;
import java.io.Reader;

public class PlaMemoKR
{
    public static void main(String[] args) throws IOException, ParseException
    {
        Reader json = new FileReader("./scenario_json/루트 공통/pm01_01.txt.scn.json");


        JSONParser jParser = new JSONParser();
        JSONObject jObject = (JSONObject) jParser.parse(json);
        JSONArray jArray = (JSONArray) jObject.get("scenes");

        jObject = (JSONObject) jParser.parse(jArray.get(0).toString());
        JSONArray jArray1 = (JSONArray) jObject.get("texts");

        for (Object a : jArray1)
        {
            jArray = (JSONArray) a;
            if(jArray.get(0) == null && jArray.get(1) == null)
            {
                System.out.println(jArray.get(2));//0, 1은 null 2는 텍스트
            }
        }
    }
}
