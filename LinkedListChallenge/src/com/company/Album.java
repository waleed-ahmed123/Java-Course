package com.company;

import java.util.ArrayList;
import java.util.LinkedList;


public class Album {
    private String name;
    private String artist;
    private ArrayList<Song> songs;

    public Album(String name, String artist) {
        this.name = name;
        this.artist = artist;
        this.songs = new ArrayList<Song>();
    }

    public boolean addSong(String title, double duration) {
        if (findSong(title) == null) { // check if thr song already exists
            this.songs.add(new Song(title, duration)); // if it doesnt add it
            return true;
        }
        return false; // else dont
    }

    private Song findSong(String title) {
        for (Song checkedSong : this.songs) { //for every entry in our arraylist, java creates a variable called checkedSong
            //and if it equals to the title, it returns the title itself, otherwise it returns null.
            if (checkedSong.getTitle().equals(title)) {
                return checkedSong;
            }
        }
        return null;
    }

    public boolean addToPlayList(int trackNumber, LinkedList<Song> playList) {
        int index = trackNumber - 1;//starts from index 0
        if ((index > 0) && (index <= this.songs.size())) {// checks if there are songs in the playlist
            playList.add(this.songs.get(index));//add song to playlist
            return true;
        }
        System.out.println("This album does not have a track " + trackNumber);
        return false;
    }

    public boolean addToPlayList(String title, LinkedList<Song> playList) {
        Song checkedSong = findSong(title);
        if (checkedSong != null) { // checks if the song exists in the playlist or not
            playList.add(checkedSong); // if it doesnt, add it to the playlist
            return true;
        }
        System.out.println("The song " + title + " is not in this album");
        return false; // otherwise dont.
    }


}