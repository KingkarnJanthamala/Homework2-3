using System;

class Program {
    static void Main(string[] args) {
        while (true) {
            string o_perator = Console.ReadLine(); //o_perator คืออักขระเครื่องหมาย
            if ((o_perator == "+") || (o_perator == "-")) {
                if (o_perator == "+") {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                float[ , ] Matrix1 = new float[m,n];
                Matrix_1(m , n , ref Matrix1);
                float[ , ] Matrix2 = new float[m,n]; 
                Matrix_2(m , n , ref Matrix2);
                float[ , ] result = new float[m,n];
                PlusMatrix(m , n , ref result , ref Matrix1 , ref Matrix2);        
                } else {
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                float[ , ] Matrix1 = new float[m,n];
                Matrix_1(m , n , ref Matrix1);
                float[ , ] Matrix2 = new float[m,n]; 
                Matrix_2(m , n , ref Matrix2);
                float[ , ] result = new float[m,n];
                MinusMatrix(m , n , ref result , ref Matrix1 , ref Matrix2);
                }
                continue;
            } else {
                break;
        }
    }
    }
    static void Matrix_1(int m , int n ,ref float[ , ] Matrix1) { //Matrix_1() คือฟังก์ชันรับค่าจากผู้ใช่ไปเก็บที่อาเรย์ เมทริกซ์ที่ 1
        for(int row = 0 ; row < m ; row++) {
            for(int col = 0 ; col < n ; col++) {
                Matrix1[row,col] = float.Parse(Console.ReadLine());
            }
        }
    }
    static void Matrix_2(int m , int n ,ref float[ , ] Matrix2) { //Matrix_2() คือฟังก์ชันรับค่าจากผู้ใช่ไปเก็บที่อาเรย์ เมทริกซ์ที่ 2
        for(int row = 0 ; row < m ; row++) {
            for(int col = 0 ; col < n ; col++) {
                Matrix2[row,col] = float.Parse(Console.ReadLine());
            }
        }
    }
    static void PlusMatrix(int m , int n , ref float[ , ] result , ref float[ , ] Matrix1 , ref float[ , ] Matrix2) { //PlusMatrix() คือฟังก์ชันเมทริกซ์การบวก
         for(int row = 0 ; row < m ; row++) {
            for(int col = 0 ; col < n ; col++) {
            result[row,col] = Matrix1[row,col] + Matrix2[row,col];
            Console.Write("{0:F1} " , result[row,col]);
            }
            Console.WriteLine();
        }
    }
    static void MinusMatrix(int m , int n , ref float[ , ] result , ref float[ , ] Matrix1 , ref float[ , ] Matrix2) { //MinusMatrix() คือฟังก์ชันเมทริกซ์การลบ
        for(int row = 0 ; row < m ; row++) {
            for(int col = 0 ; col < n ; col++) {
            result[row,col] = Matrix1[row,col] - Matrix2[row,col];
            Console.Write("{0:F1} " , result[row,col]);
            }
            Console.WriteLine();
        }
    }
}