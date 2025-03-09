1. Observer được sử dụng để theo dõi trạng thái đơn hàng và tự động thực hiện các hành động khi đơn hàng được tạo.
2. ✅ Tách biệt logic thông báo (Gửi email, cập nhật kho) khỏi OrderSubject.
✅ Dễ mở rộng: Có thể thêm nhiều loại Observer khác mà không cần thay đổi OrderSubject.
✅ Tăng tính linh hoạt: Có thể thêm hoặc gỡ bỏ các Observer mà không ảnh hưởng đến code hiện tại.
