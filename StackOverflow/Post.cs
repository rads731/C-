using System;

namespace StackOverflow
{
    class Post {
        public string Title;
        public string Description;
        public DateTime Date_Time;
        private int TotalVote;

       public Post(string ti,string des,DateTime dateTime) {
            this.Title = ti;
            this.Description = des;
            this.Date_Time = dateTime;
            //this.TotalVote = 0;
        }

       
        public int UpVote() {
            TotalVote += 1;
            return TotalVote;
        }
        public int DownVote() {
            TotalVote -= 1;
            return TotalVote;
        }

        public void Display() {
            Console.WriteLine("{0}  {1}  {2}  {3}  ",Title,Description,Date_Time,TotalVote);
        }
    }
}
