package com.haruww.plamemokr;

import java.io.File;
import java.util.ArrayList;

public class Files
{
    ArrayList<String> list;

    public ArrayList<String> getFileDirs(String dirPath)
    {
        list = new ArrayList<>();
        addDirToList(dirPath);
        return list;
    }

    private void addDirToList(String dirPath)
    {
        File dir = new File(dirPath);
        File files[] = dir.listFiles();

        for (int i = 0; i < files.length; i++)
        {
            File file = files[i];
            if (file.isDirectory())
            {
                addDirToList(file.getPath());
            }
            else
            {
                list.add(file.toString());
            }
        }
    }
}
