I. Dictionary: Để tạo một dictionary:

Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                {"so 1", new Product{Name = "so 1 name", Price = 100M} },
                {"so 2", new Product{Name = "so 2 name", Price = 1000M} }
            };

Hoặc:

 Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["so 1"] = new Product{Name = "so 1 name", Price = 100M} ,
                ["so 2"] = new Product{Name = "so 2 name", Price = 1000M} 
            };

//Trong đó "so 1" là string; new........ là Product ( xét ở Dictionary<string, Product>)

II.

if(ob is decimal x) : Với ob thuộc kiểu object; hàm "is" sẽ trả về true và gán giá trị của ob cho x nếu ob có kiểu dữ liệu a=là decimal.
Ngược lại trả về giá trị false.

/*-------------------------------------------------------------------*/
switch (data[i]) {
 case decimal decimalValue:
 total += decimalValue;
break;
 case int intValue when intValue > 50:
 total += intValue;
break;
}

Đoạn code trên có giá 

/*-------------------------------------------------------------------*/
new String[] { $"Total: {a}" }: Cách để tạo mới string

/*-------------------------------------------------------------------*/
Có thể dùng Fomat để tạo string.

III. Biểu thức lambda trong c#:
public static IEnumerable<Product> FilterByName(
 this IEnumerable<Product> productEnum, char firstLetter) {
	 foreach (Product prod in productEnum) {
	 if (prod?.Name?[0] == firstLetter) {
		 yield return prod;
		 }
	 }
 }

 IV. Defining Functions

 V. Biểu thức và các phương thức lambda:

 return View(Product.GetProducts().Select(p => p?.Name));

 public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name)); (Hay dùng; trong đó getProducts là phương thức static)

 public bool NameBeginsWithS => Name?[0] == 'S';

 VI.Using Asynchronous Methods

 VII.Working with Tasks Directly

 VIII.Applying the async and await Keywords