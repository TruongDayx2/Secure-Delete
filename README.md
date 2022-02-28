# Secure-Delete
How Do I uninstall or remove the Secure Folder?

Giải thích:
# Thuật toán: - Ghi đè dữ liệu n lần vào dữ liệu của file cần xóa.
		  - Ta đặt size file về 0 bytes.
		  - Ta thay đổi thời gian.
		  - Đổi tên và phần mở rộng của file.
		  - Sau đó là xóa file.
# Ngôn ngữ: C#  -  Visual Studio 2019.(Link video: https://drive.google.com/drive/folders/1dj5l3OHZvEXG5RowVpUtKPI7HPkKMCc0?usp=sharing)
# Hàm chính để xóa file: Dòng 42  Dòng 94
	- Dòng 42: Tên hàm: Delete_File
	- Dòng 45: File.SetAttributes - Đặt lại thuộc tính file thành bình thường.
	- Dòng 48: Math.Ceiling  - Tính tổng số sector trong file.
	- Dòng 51: byte[] bo_dem = new byte[512]  - Tạo một bộ đệm giả kiểu dữ liệu byte có kích thước bằng 1 sector.
	- Dòng 54: RNGCryptoServiceProvider – Dùng để tạo một bộ mã ngẫu nhiên để làm dữ liệu rác(Dùng từ thư viện System.Security.Cryptography ).
	- Dòng 56: FileStream inputStream = new FileStream(filename, FileMode.Open) – Mở file vào inputStream.
	- Dòng 60: Sử dụng for cho vòng lặp ghi đè n lần.
	- Dòng 63: inputStream.Position = 0 – Đặt lại vị trí bắt đầu mỗi vòng lặp.
	- Dòng 66: Sử dụng for cho vòng lặp cho sectors.
	- Dòng 69: rng.GetBytes(bo_dem) – Điền vào bộ đệm giả với dữ liệu ngẫu nhiên.
	- Dòng 72: inputStream.Write – Viết bộ đệm giả vào inputStream.
	- Dòng 77: inputStream.SetLength(0) – Đặt size file thành 0 bytes.
	- Dòng 80: inputStream.Close() – Đóng inputStream.
	- Dòng 84-85-86: File.SetCreationTime , File.SetLastAccessTime , File.SetLastWriteTime  -  Đặt lại thời gian tạo, truy cập và chỉnh sửa.
	- Dòng 90: File.Move  - Đặt lại tên và phần mở rộng.
	- Dòng 93: File.Delete  - Xóa file.
