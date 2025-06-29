using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_git
{
    public class people
    {
        // ptroperty
        private string _name;
        private string _occupation;
        private int _age;
        //
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("nhap sai ten");
                }
                _name = value.Trim();
            }
        }
        public string Occupation
        {
            get => _occupation;
            set
            {
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("nhap sai ten");
                }
                _occupation = value.Trim();
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value == null)
                    throw new ArgumentException("nhap sai so");
                _age = value;
            }
        }
        // list
        public override string ToString()
        {
            return $"Họ tên: {Name}, Tuổi: {Age}, nghề nghiệp:  {Occupation}";
        }

    }
    public class work_1
    {
        private int _length;
        private string _name;
        private float _remainingtime;
        private int _toltal_time;
        private int con_time;
        private string _trang_thai;
        //get_set
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Trang_thai_1
        {
            get => _trang_thai;
            set => _trang_thai = value;
        }
        public int Toltal_time
        {
            get => _toltal_time;
            set => _toltal_time = value;
        }
        public int Length
        {
            get => _length;
            set => _length = value;
        }
        public float Remaning_time
        {
            get => _remainingtime;
            set => _remainingtime = value;

        }
        public int Con_time
        {
            get => con_time;
            set => con_time = value;
        }


        public string Trang_thai(int now_index)
        {
            int current = (int)Length * (now_index) / Toltal_time;
            string a;
            if (now_index < Toltal_time) {  a = new string('-', current) + new string(':', Length - current); }
            else { a = "hoan thanh"; }

                
            return a;
        }
        public float[] time(int now)
        {
            float[] a = new float[2];
            a[0] = ((float)now / (float)Toltal_time)*100 ;
            a[1] = Toltal_time - now;
            return a;
        }
        
           
        public override string ToString()
        {
            return $"{_name} : {_remainingtime:F2} %   :  {_trang_thai}   {con_time}"  
            ;
        }
    }
    


}
