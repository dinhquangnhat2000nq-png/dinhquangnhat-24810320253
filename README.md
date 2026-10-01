Câu 1: Value Types và Reference Types trong C#

Value Types (kiểu giá trị) và Reference Types (kiểu tham chiếu) khác nhau chủ yếu ở cách dữ liệu được lưu trữ và cách biến tham chiếu đến dữ liệu.

Value Type: biến chứa trực tiếp giá trị của dữ liệu.
Ví dụ: int, double, bool, struct, enum.
Khi gán một biến Value Type cho biến khác, giá trị được sao chép.
Thông thường biến cục bộ Value Type có thể được lưu trên Stack, nhưng không nên hiểu rằng mọi Value Type luôn nằm trên Stack (ví dụ khi là field của object thì dữ liệu có thể nằm trên Heap).
Reference Type: biến chứa tham chiếu (reference) đến đối tượng.
Ví dụ: class, string, array, delegate.
Đối tượng thường được cấp phát trên Heap, còn biến reference có thể nằm trên Stack hoặc ở nơi khác tùy ngữ cảnh.
Khi gán một Reference Type cho biến khác, hai biến có thể cùng tham chiếu đến một đối tượng.

Ví dụ:

int a = 10;
int b = a;
b = 20;
// a vẫn bằng 10

Person p1 = new Person();
Person p2 = p1;
p2.Name = "An";
// p1.Name cũng là "An"

Lưu ý: Quy tắc "Value Type = Stack, Reference Type = Heap" là cách giải thích nhập môn, nhưng không hoàn toàn chính xác về mặt triển khai của CLR.

Câu 2: Init-only Property (init) khác gì set?

init cho phép thuộc tính chỉ được gán trong quá trình khởi tạo đối tượng, thay vì có thể thay đổi bất cứ lúc nào như set.

Dùng set:

class Student
{
    public string Name { get; set; }
}

var s = new Student();
s.Name = "An";
s.Name = "Bình"; // Có thể thay đổi

Dùng init:

class Student
{
    public string Name { get; init; }
}

var s = new Student
{
    Name = "An"
};

s.Name = "Bình"; // Lỗi

init phù hợp khi muốn tạo đối tượng gần như bất biến (immutable) sau khi khởi tạo, ví dụ các DTO, cấu hình ứng dụng, model dữ liệu hoặc các đối tượng chứa thông tin không nên bị thay đổi sau khi tạo.

Câu 3: virtual và override trong Polymorphism
virtual được khai báo ở lớp cha, cho phép phương thức được ghi đè ở lớp con.
override được khai báo ở lớp con, dùng để cung cấp cách triển khai mới cho phương thức virtual của lớp cha.

Ví dụ:

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

Khi sử dụng:

Animal animal = new Dog();
animal.Speak();

Kết quả:

Dog barks

Đây chính là đa hình động (runtime polymorphism): mặc dù biến có kiểu Animal, phương thức thực tế được gọi là phiên bản Speak() của Dog.

Câu 4: Tại sao static không thể truy xuất thông qua Object Instance?

Thành phần static thuộc về Class, không thuộc về từng Object Instance.

Ví dụ:

class Student
{
    public static int Count = 0;
    public string Name;
}

Count là thành phần dùng chung cho toàn bộ lớp Student, vì vậy phải truy cập thông qua tên lớp:

Student.Count++;

Không truy cập như:

Student s = new Student();
s.Count++; // Không hợp lệ

Trong khi đó, Name thuộc về từng object:

Student s1 = new Student();
Student s2 = new Student();

s1.Name = "An";
s2.Name = "Bình";

Mỗi object có một Name riêng, nhưng Count chỉ có một bản dùng chung cho lớp.

Tóm lại:

Thành phần	Thuộc về	Cách truy cập
static	Class	ClassName.Member
Không static	Object Instance	object.Member

Điểm cốt lõi là: static tồn tại ở cấp độ lớp, còn instance member tồn tại gắn với từng đối tượng được tạo bằng new.
