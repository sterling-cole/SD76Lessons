﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repo
{
   public class StreamingContent_Repo
    {
        private readonly List<StreamingContent> _directory = new List<StreamingContent>();

        public int  Count { get
            {
                return _directory.Count;
            }
        }
        //CRUD methods
        // Create
        // Read
        //Update
        // Delete


        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _directory.Count;
            // return true or false - did the add method work?
            _directory.Add(content);

            bool wasAdded = _directory.Count > startingCount;
            return wasAdded;
        }

        public List<StreamingContent> GetContents()
        {
            return _directory;   
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _directory)
            {
                if (title.ToLower() == content.Title.ToLower())
                {
                    return content;
                }
            }
            // Really, we would want to throw an error and then handle it (null is for testing purposees)
            throw new Exception("No content with that title ezists");
            //return null;
        }

        //Challenge:
        // Write a method that returns a list of only family-friendly content
       public List<StreamingContent> GetFamilyFriendlyContent()
        {
            List<StreamingContent> familyFriendly = new List<StreamingContent>();
            foreach (StreamingContent content in _directory)
            {
                if (content.IsFamilyFriendly)
                {
                    familyFriendly.Add(content);
                }
            }
            return familyFriendly;
        }


     public bool UpdateExistingContent(string origianlTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(origianlTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.StarRating = newContent.StarRating;
                oldContent.GenreType = newContent.GenreType;

                return true;
            }
            return false;
        }


        public bool DeleteContent(string title)
        {
            StreamingContent contentToDelete = GetContentByTitle(title);
            return _directory.Remove(contentToDelete);
        }

    }
}
