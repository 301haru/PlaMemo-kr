package com.haruww.plamemokr;

import org.json.simple.parser.ParseException;

import java.io.IOException;
import java.util.ArrayList;

public class PlaMemoKR
{
    static final int VALUE = 0;

    //VALUE 0 : JSON to CSV
    //VALUE 1 : CSV to JSON


    //===============================
    //실수로 실행하기 방지위한 주석처리
    //===============================

    /*
    public static void main(String[] args)
    {
        Files files = new Files();


        ArrayList<String> jsonFiles = files.getFileDirs("./scenario_json");
        ArrayList<String> csvFiles = files.getFileDirs("./scenario_csv");

        switch (VALUE)
        {
            case 0:
            {
                try
                {
                    for (String fileName : jsonFiles)
                    {
                        JSONtoCSV.toCSV(fileName);
                    }
                }
                catch (IOException | ParseException e)
                {
                    e.printStackTrace();
                }
                break;
            }
            case 1:
            {


                for(int i=0; i<csvFiles.size(); i++) // i<csvFiles.size()
                {
                    String f1 = csvFiles.get(i);
                    String f2 = jsonFiles.get(i);
                    try
                    {
                        CSVtoJSON.toJSON(f1, f2);
                    } catch (IOException | ParseException e)
                    {
                        e.printStackTrace();
                    }
                }
                break;
            }
        }
    }*/
}
