using SemantleGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemantleGame.Models
{
    public class UserLogModel : ViewModelBase
    {
        /// <summary>
        /// private 변수 대신 public Property를 써야 하나요?
        // WPF의 데이터 바인딩(Binding) 시스템 때문에 Public 속성(Property)으로 만들어야 한다.
        // IPersonModel은.. 이번 프로젝트에서는 만들지 않는 걸로
        /// </summary>
        public int Idx { get; set; }
        public string UserInputWord { get; set; }
        public float Similarity { get; set; }
        public int Ranking { get; set; }        
        public UserLogModel(int idx, string userInput, float similarity, int rank)
        {
            Idx = idx;
            UserInputWord = userInput;
            Similarity = similarity;
            Ranking = rank;
        }

        // ToString()이 아니라 개별 바인딩해야 함
        // public override string ToString()
    }
}
