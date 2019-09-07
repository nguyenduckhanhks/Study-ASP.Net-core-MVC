/*------------------------------------------------------------*/
/*------------------Kiến thức cần biết------------------------*/
/*------------------------------------------------------------*/
# Razor
# Tag Helper
# LinQ
# HttpGet và HttpPost





/*------------------------------------------------------------*/
/*-----------------------Một số chi tiết----------------------*/
/*------------------------------------------------------------*/

1. asp-action: Dùng để chỉ định URL cho form; view
2. asp-for: Dùng để chỉ định kiểu dữ liệu trong thẻ input có giá trị là thuộc tính trong 
	model được khai báo.
	Ví dụ:
	<label asp-for="Name">Your name:</label>
	<input asp-for="Name" />
	
	Tương đương với:
	<label for="Name">Your name:</label>
 	<input type="text" id="Name" name="Name" value="">

3.Thuộc tính action trong form của html dùng để chỉ ra url mà form gửi đến
4.Thuộc tính method trong form cuaur html có giá trị bằng get hoặc post.
	Sử dụng method="get" thì khi submit dữ liệu được biểu diễn thông qua URL. 
	Sử dụng method="post" thì khi submit biểu diễn trong nội dung của Request gửi đến Server và là ẩn với người dùng,
	sử dụng post an toàn hơn.
5.thuộc tính for trong label:
	Khi thêm for trong label để biểu thị text trước ô thẻ input (giá trị của g=for trugnf với id trong thẻ input.
	Khi đó ta có thể nhấp chuột vào phần text đó để nhập vào input.

6. input type = "submit" : Tạo ra một nút bấm; khi bấm vào thì dữ liệu sẽ được gửi đi.

7.htmlGet: Các yêu cầu dữ liệu từ một nguồn chỉ định
8.HtmlPost: Gửi dữ liệu để xử lí tối một nguồn nhất định

9.Thêm Xác nhận  đâu vào thẻ input:
	Ta dùng: using System.ComponentModel.DataAnnotations; Trong file model
	trên mỗi thuộc tính trong class; ta dùng [Required(ErrorMessage = "Please enter your name")]
	Khi đó để kiểm tra và phân luồng cho control ta dùng: if (ModelState.IsValid) co control đó 

	Để hiển thị errorMessage. ta thêm <div asp-validation-summary="All"></div> vào file cshtml. 
10. dùng validation để chỉ định cách hiển thị khi dữ liệu lỗi