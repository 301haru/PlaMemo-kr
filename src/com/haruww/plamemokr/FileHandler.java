package com.haruww.plamemokr;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

public class FileHandler
{
    public static void writeCSV(ArrayList list, String fileName) throws IOException
    {
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


    //아래쪽 코드 개판입니다. 일회성.

    static ArrayList<String> list = new ArrayList<>();
    public static ArrayList<String> getFileDirs(String dirPath)
    {
        addDirToList(dirPath);
        return list;
    }

    private static void addDirToList(String dirPath)
    {
        File dir = new File(dirPath);
        File files[] = dir.listFiles();

        for (int i = 0; i < files.length; i++)
        {
            File file = files[i];
            if (file.isDirectory())
            {
                getFileDirs(file.getPath());
            }
            else
            {
                list.add(file.toString());
            }
        }
    }
}
