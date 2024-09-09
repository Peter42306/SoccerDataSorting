﻿namespace SoccerDataSorting.Models
{
    public enum SortStatePlayer
    {
        NameAsc,    // по имени игрока по возрастанию
        NameDesc,   // по имени игрока по убыванию
        AgeAsc, // по возрасту по возрастанию
        AgeDesc,    // по возрасту по убыванию
        PositionAsc, // по позиции по возрастанию
        PositionDesc,    // по позиции по убыванию
        TeamAsc, // по клубу по возрастанию
        TeamDesc // по клубу по убыванию
    }    

    public enum SortStateTeam
    {
        NameAsc,
        NameDesc,
        CoachAsc,
        CoachDesc
    }
}
