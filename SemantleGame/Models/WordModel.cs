using System;
using System.Collections.Generic;
using System.ComponentModel;

using SemantleGame.Services;
using SemantleGame.ViewModels;

namespace SemantleGame.Models
{
    // INotifyPropertyChanged
    public class WordModel : ViewModelBase, INotifyPropertyChanged
    {
        public string? Word { get; set; }       // 단어
        public float[]? Vector { get; set; }   // 벡터값 -> 소수점

        public WordModel(string word, float[] vector)
        {
            Word = word;
            Vector = vector;
        }
    }
}