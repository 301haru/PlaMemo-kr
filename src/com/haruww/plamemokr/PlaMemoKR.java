package com.haruww.plamemokr;

import org.json.simple.parser.ParseException;

import java.io.IOException;
import java.util.ArrayList;

public class PlaMemoKR
{

    static final int VALUE = 0;

    //VALUE 0 : JSON to CSV
    //VALUE 1 : CSV to JSON

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
                    for(int i=0; i<jsonFiles.size(); i++)
                    {
                        String fileName = jsonFiles.get(i);
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
                CSVtoJSON.toJSON();
            }
        }
    }
}
