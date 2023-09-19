namespace Bonus_Assignment_210042106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crating a new Lecturer Object
            Lecturer l1 = new Lecturer();
            l1.name = "Md. Korim Mia";
            l1.dept = "CSE";
            l1.book = 8;
            l1.quarter_room = 109;
            //Creating 2nd Lecturer
            Lecturer l2 = new Lecturer();
            l2.name = "Sabrina Aktar";
            l2.dept = "EEE";
            l2.book = 0;
            l2.quarter_room = 0;
            //Creating 3rd Lecturer
            Lecturer l3 = new Lecturer();
            l3.name = "Mahmud hasan Khan";
            l3.dept = "IPE";
            l3.book = 2;
            l3.quarter_room = 206;
            //Creating 1st Professor
            Professor p1 = new Professor();
            p1.name = "Dr. Nobab Siraj ud Doula";
            p1.dept = "CSE";
            p1.book = 43;
            p1.paper_count = 23;
            p1.yearly_research_budget = 500000;
            p1.house_no = 1;
            //Creating 2nd Professor
            Professor p2 = new Professor();
            p2.name = "Dr. Jalaluddin Muhammad Akbar Padshah";
            p2.dept = "EEE";
            p2.book = 12;
            p2.paper_count = 8;
            p2.yearly_research_budget = 90000;
            p2.house_no = 6;
