// See https://aka.ms/new-console-template for more information

/*
    - Cách khai báo class (normal, abstract), interface: giống Java
    - Cách khai báo thuộc tính, phương thức: giống java
        public class Ten_class{
            Access_Modifier Ten_attr;
            Access_Modifier Data_type Ten_method(data_type para_name){
                code_block;
            }
        }
        
        public abstract class Ten_class{
            Access_Modifier Ten_attr;
            Access_Modifier Data_type Ten_method(data_type para_name){
                code_block;
            }
            Access_Modifier abstract data_type Ten_method(data_type para_name);
        }
        
        public interface ten_interface{
            Access_Modifier abstract data_type Ten_method(data_type para_name);
        }
    - Cách tạo đối tượng: giống java
        Ten_class ten_doi_tuong = new ten_class();
    - Tính kế thừa (inheritance): giống C++
        class A kế thừa class B
            class_A : class_B
    - Tính đa hình (Polymorphism): giống java
    - Tính đóng gói (Encapsulation): giống Java
    - Tính trừu tượng (Abstraction): giống Java
        class A implement interface B
            class_A : interface_B
*/

using ConsoleApp1;

public class main
{
    public static void Main()
    {
        Retangle retangle = new Retangle();
    }
}