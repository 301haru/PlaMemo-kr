package com.haruww.plamemokr;

import org.json.simple.parser.ParseException;

import java.io.IOException;
import java.util.ArrayList;

public class PlaMemoKR
{
    public static void main(String[] args)
    {
        ArrayList<String> root = FileHandler.getFileDirs("./scenario_json");
        //System.out.println(root);
        try
        {
            for (String fileName : root)
            {
                ArrayList arrayList = Parser.decryptJSON(fileName);
                FileHandler.writeCSV(arrayList, fileName);
            }
        } catch (IOException | ParseException e)
        {
            e.printStackTrace();
        }
    }
}
