# BAI_TAP_WEB_DOANSO
BÀI TẬP VỀ NHÀ 01:
TẠO SOLUTION GỒM CÁC PROJECT SAU:
DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.</p>

# Tạo các projects. 
<img width="1252" height="830" alt="image" src="https://github.com/user-attachments/assets/b69a94ff-cbd1-4127-96a5-80ed61a5f232" /> </p>
# Sau khi tạo song. 
<img width="369" height="594" alt="image" src="https://github.com/user-attachments/assets/8c051427-4351-4a07-8453-110c016445a5" /> </p>
# BÀI LÀM: GAME ĐOÁN SỐ 
# Cấu trúc Class Library .NET 2.0
<img width="238" height="108" alt="image" src="https://github.com/user-attachments/assets/fcd9e386-d252-4299-ae21-dcbc1135137e" />
<img width="1280" height="628" alt="image" src="https://github.com/user-attachments/assets/bddf4341-aea7-4892-bbc5-ed7d725e4ac9" /> </p>

# Cấu trúc Console App .NET 2.0 </p>
<img width="267" height="212" alt="image" src="https://github.com/user-attachments/assets/7b668664-3154-4e2a-a3d3-e04691c561e3" />
<img width="1564" height="620" alt="image" src="https://github.com/user-attachments/assets/ae2372bf-7cb7-4a6c-8d01-e66863446734" /> </p>
 # Cấu trúc Windows Form Application .NET 2.0 </p>
<img width="288" height="353" alt="image" src="https://github.com/user-attachments/assets/9892dad3-7c1d-4947-8a0a-c23d6a365910" /></p>
<img width="1236" height="701" alt="image" src="https://github.com/user-attachments/assets/c65f0635-f726-4b80-9613-a53f7c81cd5e" />
<img width="1308" height="710" alt="image" src="https://github.com/user-attachments/assets/8d15c077-0724-47c3-87c1-9b03dae5ee8c" /> </p>
# Cấu trúc web </p>
<img width="344" height="478" alt="image" src="https://github.com/user-attachments/assets/adc17807-4552-40b5-96c0-6d5f59dca61f" /> </p>
# Tạo folder cho web </p>
<img width="1700" height="639" alt="image" src="https://github.com/user-attachments/assets/46c1e475-bd7b-4e44-891f-2bf6866b2190" /> </p>
# add web cho iis </p>
<img width="1405" height="521" alt="image" src="https://github.com/user-attachments/assets/a1062c25-0885-4ad8-a6aa-4b50775af8f3" /> </p>
# Tạo domain </p>
<img width="949" height="713" alt="image" src="https://github.com/user-attachments/assets/bf903455-3037-4b8b-b68e-5b9a7ca8e053" /> </p>
# Kết quả </p>
<img width="1156" height="580" alt="image" src="https://github.com/user-attachments/assets/dc2bd8c7-1c5c-4b1c-903b-06e0af667d8d" /> </p>

