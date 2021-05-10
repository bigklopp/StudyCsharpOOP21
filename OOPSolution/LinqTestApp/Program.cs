using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하동훈", Height = 171 });

            List<Profile> newprofiles = new List<Profile>();

            Console.WriteLine("전체 프로필 리스트");
            foreach (var item in profiles)
            {
                Console.WriteLine($"{item.Name} {item.Height} cm");
            }
            /*foreach(var item in profiles)
            {
                if(item.Height < 172)
                {
                    newprofiles.Add(item);
                }
            }*/
            Console.WriteLine("리스트 중 키가 172cm 보다 작은 사람들");
            /*foreach (var item in newprofiles)
            {
                Console.WriteLine($"{item.Name} {item.Height} cm");
            }*/


            var newProfiles = from item in profiles
                              where item.Height < 172
                              //키 큰 순으로 정렬하기
                              orderby item.Height descending
                              select item;
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} {item.Height} cm");
            }
            //
            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }

            var result = from item in numbers
                         where item % 3 == 0
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }

            var profiles1 = from item in profiles
                            orderby item.Height descending
                            select item;
            Console.WriteLine("키 오름/내림 차순 정렬");
            foreach (var item in profiles1)
            {
                Console.WriteLine($"{item.Name} {item.Height} cm");
            }
            var profiles2 = from item in profiles
                            orderby item.Height descending
                            select item.Name;
            Console.WriteLine("키 오름/내림 차순 정렬 이름만");
            foreach (var item in profiles2)
            {
                Console.WriteLine($"{item} ");
            }
            var profiles3 = from item in profiles
                            orderby item.Height descending
                            select new
                            {
                                Name = item.Name,
                                Inch = item.Height * 0.393
                            };

            Console.WriteLine("키 오름/내림 차순 정렬 인치로");
            foreach (var item in profiles3)
            {
                Console.WriteLine($"{item.Name} {item.Inch} in. ");
            }

            //15.3
            InstClass[] arrClasses = {
                new InstClass() { Name = "연두반", Scores = new int[] {99, 80, 70, 24} },
                new InstClass() { Name = "분홍반", Scores = new int[] {60, 45, 87, 72} },
                new InstClass() { Name = "파랑반", Scores = new int[] {92, 30, 85, 94} },
                new InstClass() { Name = "노랑반", Scores = new int[] {90, 88, 0, 17} }
            };

            var rstClasses = from item in arrClasses
                             from score in item.Scores
                             where score < 60
                             orderby score ascending
                             select new { item.Name, Lowest = score };
            foreach (var item in rstClasses)
            {
                Console.WriteLine($"{item.Name} {item.Lowest}");
            }


            //group by 예제
            var listprofiles = from item in profiles
                               group item by item.Height < 172 into g
                               select new
                               {
                                   GroupKey = g.Key,
                                   Profiles = g
                               };
            foreach (var item in listprofiles)
            {
                Console.WriteLine($"- 172cm 미만 : {item.GroupKey}");
                foreach (var sub in item.Profiles)
                {
                    Console.WriteLine($">>> {sub.Name} : {sub.Height}");
                }
            }
        }
    }
}

