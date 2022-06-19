using System;

namespace EmployeeRecruitmentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MELUMATLANDIRMA :");
            Console.WriteLine("**Ad,Soyad,Ata adi daxil ederken ilk herf boyuk herfle bashlamalidir,yalniz herflerle yazilmalidir.\n**Ad ve ata adinin uzunlugu minimum 2 ve max 20 olmalidir.Soyadin ise uzunlugu 35 olmalidir.");
            Console.WriteLine("**Yash 18 ve 65 yas araliginda olmalidir \n**Fin kod daxil edilerken herflerin hamsi boyuk olmalidir");
            Console.WriteLine("**Telefon nomresi yalniz '+994' ile bashlamalidir ve uzunlugu 13 olmalidir");
            Console.WriteLine("**Maash 1500 ve 3000 manat araliginda olmalidir");

            Console.Write("Adi daxil edin :");
            string name = Console.ReadLine();
            Console.Write("Soyadi daxil edin :");
            string surname = Console.ReadLine();
            Console.Write("Ata adi daxil edin :");
            string fathername = Console.ReadLine();
            Console.Write("Yasini daxil edin :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fin'i daxil edin : ");
            string fincode = Console.ReadLine();
            Console.Write("Telefon nomresini daxil edin :");
            string phonenumber = Console.ReadLine();
            Console.WriteLine("Pozisiyalar : HR,Audit,Engineer");
            Console.Write("Poziyasini daxil edin (Yuxarida qeyd olundugu kimi yazin!) : ");
            string position = Console.ReadLine();
            Console.Write("Maashi daxil edin :");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");

            Employee firstEmployee = new Employee(name, surname , fathername, age, fincode, phonenumber, position, salary);


        }
    }


    public class Employee
    {
        public string _name;
        public string _surname;
        public string _fathername;
        public int _age;
        public string _finCode;
        public string _phonenumber;
        public string _position;
        public int _salary;



        public Employee(string name, string surname, string fathername, int age, string fincode, string phonenumber, string position, int salary)
        {
            _name = name;
            _surname = surname;
            _fathername = fathername;
            _age = age;
            _finCode = fincode;
            _phonenumber = phonenumber;
            _position = position;
            _salary = salary;


            if (CheckName(name) & CheckFincode(fincode) & IsAGe(age) & CheckSurname(surname)  & CheckFatherName(fathername) & CheckPhoneNumber(phonenumber) & IsPosition(position) & IsSalary(salary))
            {
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine($"{name} {surname} sisteme daxil edildi !");
            }

        }

        /////////////// DIQQET !!!!!!!!!!
        //////////     Iki ve ya daha cox methoddan istifade edilibse her soze  check adli methodda birlesdirilib 
        ///           meselen name 3 methoddan ibaret idi deye ucunu CheckName adli methodda birleshdirdim
        

        public bool CheckName(string name)
        {
            bool check = true;

            if (!IsNamesLength(name))
            {
                Console.WriteLine("uzunluq sehv");
                check = false;
            }
            if (!IsFirstLetterUpper(name))
            {
                Console.WriteLine("ilk herf sehv");
                check = false;
            }
            if (IsNumberContain(name))
            {
                Console.WriteLine("Ad yazarken yalniz herflerden istifade edilmelidir");
                check = false;
            }
            return check;
        }

        public bool CheckFincode(string fincode)
        {
            bool check = true;
            if (!IsFincodeLength(fincode))
            {
                Console.WriteLine("Fincode uzunlugu sehvdir");
                check = false;
            }
            if(!CheckFincodeContent(fincode))
            {
                Console.WriteLine("Fin kod sehvdir");
                check = false;
            }

            return check;

        }

        public bool CheckFincodeContent(string fincode)
        {
            for (int i = 0; i < fincode.Length; i++)
            {
                if (!IsUpper(fincode[i]) && !IsNumber(fincode[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckSurname(string surname)
        {
            bool check = true;
            if (!IsSurNamesLength(surname))
            {
                Console.WriteLine("Soyad uzunlugu sehvdir");
                check = false;
            }
            if (!IsFirstLetterUpper(surname))
            {
                Console.WriteLine("Soyadin Ilk herfi sehvdir");
                check = false;
            }
            if (IsNumberContain(surname))
            {
                Console.WriteLine("Soyadi yazarken yalniz herflerden istifade edilmelidir");
                check = false;
            }
            return check;

        }

        public bool CheckPhoneNumber(string phonenumber)
        {
            bool check = true;
            if (!IsPhonenumberLength(phonenumber))
            {
                Console.WriteLine("nomrenin uzunlugu duzgun deyil");
                check = false;

            }
            if (!IsPhonenumberStart(phonenumber))
            {
                Console.WriteLine("nomrenin evveli '994 ile baslamalidir'");
                check = false;
            }
            return check;
        }

        public bool CheckFatherName(string fathername)
        {
            bool check = true;

            if (!IsNamesLength(fathername))
            {
                Console.WriteLine("soyadin uzunlugu sehv");
                check = false;
            }
            if (!IsFirstLetterUpper(fathername))
            {
                Console.WriteLine("soyadin ilk herfi sehv");
                check = false;
            }
            if (IsNumberContain(fathername))
            {
                Console.WriteLine("Ata adi yazarken yalniz herflerden istifade edilmelidir");
                check = false;
            }
            return check;
        }

        

        ////////////////////////////////////////////////////////////

        //name hissesi :
        public bool IsNamesLength(string employeeName)
        {
            if (employeeName.Length > 2 && employeeName.Length < 20)
            {
                return true;
            }
            
            return false;
        }

       public bool IsNumberContain(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!IsNumber(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsFirstLetterUpper(string employeeName)
        {
            char[] Upperletters = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

            for (int i = 0; i < Upperletters.Length; i++)
            {
                if (employeeName[0] == Upperletters[i])
                {
                    return true;
                }
            }
         
            return false;
        }
        //surname hissesi :
        public bool IsSurNamesLength(string employeeSurname)
        {
            if (employeeSurname.Length > 2 && employeeSurname.Length < 35)
            {
                return true;
            }
            Console.WriteLine("sozun uzunlugunda ve ya qisaliginda yanlish var");
            return false;
        }
        //age hissesi :
        public bool IsAGe(int age)
        {
            if (age > 18 && age < 65)
            {
                return true;
            }
            Console.WriteLine("yas duzgun daxil edilmeyib");
            return false;
        }
        //fincode hissesi :
        public bool IsFincodeLength(string fincode)
        {
            if (fincode.Length == 7)
            {
                return true;
            }
            Console.WriteLine("fincode`un uzunlugu duzgun deyil");
            return false;
        }


        public bool IsUpper(char letter)
        {
            char[] Upperletters = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

            for (int i = 0; i < Upperletters.Length; i++)
            {
                if (letter==Upperletters[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsNumber(char letter)
        {
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (letter == numbers[i])
                {
                    return true;
                }
            }
            return false;
        }


           

    // phone number hissesi
    public bool IsPhonenumberStart(string phonenumber)
    {
        char[] numbers = { '+', '9', '9', '4' };
        int a = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == phonenumber[i])
            {
                a++;
            }

        }
        if (a == 4)
        {
            return true;
        }
        return false;
    }

    public bool IsPhonenumberLength(string phonenumber)
    {
        if (phonenumber.Length == 13)
        {
            return true;
        }
        return false;
    }       
    //position hissesi :
    public bool IsPosition(string position)
    {
        if (position == "HR")
        {
            return true;
        }
        else if (position == "Audit")
        {
            return true;
        }
        else if (position == "Engineer")
        {
            return true;
        }
        Console.WriteLine("pozisiya duzgun deyil");
        return false;
    }

    //salary hissesi :
    public bool IsSalary(int salary)
    {
        if (salary >= 1500 && salary <= 5000)
        {
            return true;
        }
        Console.WriteLine("Maas duzgun qeyd edilmeyib");
        return false;
    }

    }

}
