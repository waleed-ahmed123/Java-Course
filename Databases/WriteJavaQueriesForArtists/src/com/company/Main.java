package com.company;

import java.util.List;

public class Main {

    public static void main(String[] args) {
        com.company.model.Datasource datasource = new com.company.model.Datasource();
        if(!datasource.open()) {
            System.out.println("Can't open datasource");
            return;
        }

        List<com.company.model.Artist> artists = datasource.queryArtists();
        if(artists == null) {
            System.out.println("No artists!");
            return;
        }

        for(com.company.model.Artist artist : artists) {
            System.out.println("ID = " + artist.getId() + ", Name = " + artist.getName());
        }

        datasource.close();
    }
}