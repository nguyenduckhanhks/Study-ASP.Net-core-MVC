/*------------------------------------------------------------*/
/*---------Triển khai từ empty--------------------------------*/
/*------------------------------------------------------------*/

I. Set Up MVC:
Vào File Startup.cs để cài đặt MVC:

public void ConfigureServices(IServiceCollection services) {
 		services.AddMvc();
 	}

 public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
 	if (env.IsDevelopment()) {
		 app.UseDeveloperExceptionPage();
 	}
 		//app.Run(async (context) => {
 		// await context.Response.WriteAsync("Hello World!");
	 	//});
 		app.UseMvcWithDefaultRoute();
 }

II. tạo các folder Views; Controllers; Models; Home; Share.

III. Toán tử điều kiện null:
	Ví dụ: string name = p?.Name
Dùng để tránh trường hợp p.Name null gây lỗi

	string name = p?.Name?? "<none>": 2 dấu hỏi chấm có tác dụng: trong trường hợp null thì lấy none làm giá trị
					dự phòng.
IV. Ví dụ: public string Category { get; set; } = "Watersports";

	=> viết như trên để thay cho cách viết get set truyền thống + gán giá trị mặc định là Watersports cho biến
V. public bool InStock { get; }

	=> Viết như trên nghĩa là biến chỉ dùng để đọc.

VI. results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");

	=> Cộng giá trị trong cặp {} vào chuỗi.

VII. Product kayak = new Product {
		 Name = "Kayak",
 		Category = "Water Craft",
 		Price = 275M
	};

	=> Dùng để khởi tạo đối tượng với giá trị tĩnh một cách nhanh chóng.

VIII.if (data[i] is decimal d) {

	=>Từ khóa is thực hiện kiểm tra loại và nếu một giá trị thuộc loại được chỉ định, nó sẽ gán giá trị cho Biến mới

IX.Pattern Matching in Switch Statements

X. Các phương thức mở rộng: là cách thêm phương thức vào các lớp mà không thể thay đổi lớp đó.

	Ví dụ ta có lớp:
		namespace LanguageFeatures.Models {
		 	public class ShoppingCart {
 				public IEnumerable<Product> Products { get; set; }
 				}
		}

	=> khi ta muốn thêm phuowng thức tính tổng price trong lớp trên ta có thể làm:

		public static class MyExtensionMethods {
 			public static decimal TotalPrices(this ShoppingCart cartParam) {
 				decimal total = 0;
 				foreach (Product prod in cartParam.Products) {
 					total += prod?.Price ?? 0;
 				}					
 				return total;
 			}
 		}

XI. Các layout dùng cho view được tạo trong views/shared.
khi sử dụng ta chỉ cần khai báo trong view:
	@{
		layout = "tên lay out"
	}

+ File Viewimports ta có thể import folder Models để thuận tiện cho khai báo model trong các view:
	EX: @using lessong2.Models
+ File _ViewStart ta có thể khai báo layout cho các view khác để thuận tiện cho việc thay đổi layout sau này.  


























