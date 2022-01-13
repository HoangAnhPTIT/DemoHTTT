using System;

namespace demoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 1;
            Console.WriteLine("         Chao mung ban den voi demo !!!");
            while (a != 0)
            {
                Console.Write("Moi ban nhap trieu chung: ");
                var str = Console.ReadLine();
                if (str == "Ợ nóng, ợ hơi, ợ chua")
                {
                    Console.WriteLine(" Có bị khó nuốt, đau tức ngực khi nuốt không ? ");
                    str = Console.ReadLine();
                    if (str == "co")
                    {
                        Console.WriteLine("ban co buon non ko");
                        str = Console.ReadLine();
                        if (str == "co")
                            Console.WriteLine("Co the ban bi Co that thuc quan");
                        else
                        {
                            Console.WriteLine("Có bị đau bụng vùng thượng vị không ?");
                            str = Console.ReadLine();
                            if (str == "co")
                            {
                                Console.WriteLine("Viêm loét dạ dày tá tràng");
                            }
                            else if (str == "khong")
                            {
                                Console.WriteLine("Có bị táo bón/ tiêu chảy không ?");
                                str = Console.ReadLine();
                                if (str == "co")
                                {
                                    Console.WriteLine("Viêm loét dạ dày tá tràng");

                                }
                                else if (str == "khong")
                                {
                                    Console.WriteLine("Ban co Đau tức ngực thượng vị");
                                    str = Console.ReadLine();
                                    if (str == "co")
                                    {
                                        Console.WriteLine("Trào ngược dạ dày");
                                    }
                                    else if (str == "khong")
                                    {
                                        Console.WriteLine("Ban co buon non, ho, khan tieng, kho nuot khong");
                                        str = Console.ReadLine();
                                        if (str == "co")
                                        {
                                            Console.WriteLine("Trào ngược dạ dày");
                                        }
                                        else if (str == "khong")
                                        {
                                            Console.WriteLine("Khong the xac nhan");
                                            Console.WriteLine("Press 0 to exit");
                                            str = Console.ReadLine();
                                            a = int.Parse(str);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (str == "khong")
                    {
                        Console.WriteLine("Có bị đau bụng vùng thượng vị không ?");
                        str = Console.ReadLine();
                        if (str == "co")
                        {
                            Console.WriteLine("Viêm loét dạ dày tá tràng");
                        }
                        else if (str == "khong")
                        {
                            Console.WriteLine("Có bị táo bón/ tiêu chảy không ?");
                            str = Console.ReadLine();
                            if (str == "co")
                            {
                                Console.WriteLine("Viêm loét dạ dày tá tràng");

                            }
                            else if (str == "khong")
                            {
                                Console.WriteLine("Ban co Đau tức ngực thượng vị");
                                str = Console.ReadLine();
                                if (str == "co")
                                {
                                    Console.WriteLine("Trào ngược dạ dày");
                                }
                                else if (str == "khong")
                                {
                                    Console.WriteLine("Ban co buon non, ho, khan tieng, kho nuot khong");
                                    str = Console.ReadLine();
                                    if (str == "co")
                                    {
                                        Console.WriteLine("Co the ban bi Trào ngược dạ dày");
                                    }
                                    else if (str == "khong")
                                    {
                                        Console.WriteLine("Khong the xac nhan");
                                        Console.WriteLine("Press 0 to exit");
                                        str = Console.ReadLine();
                                        a = int.Parse(str);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (str == "Khó nuốt, đau tức ngực khi nuốt")
                {
                    Console.WriteLine(" Có bị khó nuốt, đau tức ngực khi nuốt không và nôn ra máu không ?");
                    str = Console.ReadLine();
                    if (str == "co")
                    {
                        Console.WriteLine("Bạn có thể vị viêm thực quản");
                        Console.WriteLine("Press 0 to exit");
                        str = Console.ReadLine();
                        a = int.Parse(str);
                    }
                    else
                    {
                        Console.WriteLine(" Có bị khó nuốt, đau tức ngực khi nuốt không và Ho khàn tiếng ?");
                        str = Console.ReadLine();
                        if (str == "co")
                        {
                            Console.WriteLine("Bạn có thể bị viêm thực quản");
                            Console.WriteLine("Press 0 to exit");
                            str = Console.ReadLine();
                            a = int.Parse(str);
                        }
                        else
                        {
                            Console.WriteLine(" Có bị khó nuốt, đau tức ngực khi nuốt không và Buồn nôn ?");
                            str = Console.ReadLine();
                            if (str == "co")
                            {
                                Console.WriteLine("Bạn có thể  bị co thắt thực quản");
                                Console.WriteLine("Press 0 to exit");
                                str = Console.ReadLine();
                                a = int.Parse(str);
                            }
                            else
                            {
                                Console.WriteLine("Có bị khó nuốt, đau tức ngực khi nuốt không và Hôi miệng ?");
                                str = Console.ReadLine();
                                if (str == "co")
                                {
                                    Console.WriteLine("Bạn có thể  bị co thắt thực quản");
                                    Console.WriteLine("Press 0 to exit");
                                    str = Console.ReadLine();
                                    a = int.Parse(str);
                                }
                                else
                                {
                                    Console.WriteLine("Khong the xac nhan");
                                    Console.WriteLine("Press 0 to exit");
                                    str = Console.ReadLine();
                                    a = int.Parse(str);
                                }
                            }
                        }
                    }
                }
            }
        }


    }

}
