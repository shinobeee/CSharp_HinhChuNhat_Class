using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class HinhChuNhat
    {

        public double chieucao;
        public double chieurong;
        public double TinhDienTich()
        { 
            return chieucao*chieurong; 
        }
        public double TinhChuVi()
        { return (chieucao + chieurong) * 2; }
    }
}
