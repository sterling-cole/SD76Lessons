﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo
{
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public Maturity MaturityRating { get; set; }

        // Make IsFamilyFriendly read-only (only a getter)
        // Based on MaturityRating
        // (MaturityRating should probably be an enum)
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case Maturity.G:
                    case Maturity.PG:
                    case Maturity.TVPG:
                    case Maturity.TVY:
                    case Maturity.TVY7:
                        return true;
                    default:
                        return false;

                }
            }
        }
        public GenreType GenreType { get; set; }

        // Overloaded constructor (2 overloads)
        public StreamingContent() { }
        public StreamingContent(string title, string description, Maturity maturityRating, double stars, GenreType genre)

        {

            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = stars;
            GenreType = genre;
        }
    
    }


    public enum GenreType { Horror, Comedy, SciFi, Romance, Romans, Action, International, Drama, SciFiComedy }
    public enum Maturity { G, PG, R, PG13, NC17, TVY, TVY7, TVMA, TVPG }
}
