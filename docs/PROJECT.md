# PROJECT — Snack Shop Management

## Mục tiêu

Website bán bánh kẹo / đồ ăn vặt, gồm 2 phần: khách hàng đặt hàng online và admin quản trị cửa hàng.

## Nguồn yêu cầu

- `docs/specs/SnackShopManagement.xlsx` — đặc tả API, **v1.1 (2026-11-10)**.
- `docs/specs/SnackManagementDocuments.docx` — ERD "Cấu trúc các bảng trong database" (v1.0; v1.1 thêm bảng `refresh_tokens`).

Hai file này là **nguồn sự thật**; tài liệu trong `docs/` phải khớp với chúng.

## Hình thức

Dự án cá nhân — 1 dev (chủ dự án) + AI hỗ trợ.

## Tác nhân

| Tác nhân | Quyền chính |
|---|---|
| Khách hàng (Customer) | Đăng ký / đăng nhập / đăng xuất, xem sản phẩm & danh mục, đặt hàng (kể cả vãng lai), tra cứu & huỷ đơn, xem lịch sử, sửa hồ sơ, đổi mật khẩu |
| Quản trị viên (Admin) | Đăng nhập riêng, dashboard báo cáo, quản lý sản phẩm / danh mục / đơn hàng / người dùng / chi phí, upload ảnh |

## Phạm vi MVP (v1.1)

**Customer Module** — 14 chức năng:
- Đăng ký, đăng nhập, làm mới token, đăng xuất
- Xem danh sách / chi tiết sản phẩm, lọc & sắp xếp
- Xem danh mục
- Đặt hàng (đã đăng nhập hoặc vãng lai)
- Lịch sử đơn, xem trạng thái đơn (chủ đơn), tra cứu đơn vãng lai, huỷ đơn
- Cập nhật hồ sơ, đổi mật khẩu

**Admin Module** — 8 nhóm chức năng:
- Đăng nhập admin
- Dashboard báo cáo (doanh thu, tiền vốn, chi phí, lợi nhuận, top bán chạy; lọc theo ngày)
- Quản lý sản phẩm (CRUD + giảm giá + tồn kho)
- Quản lý danh mục (CRUD)
- Quản lý đơn hàng (danh sách, chi tiết, đổi trạng thái)
- Quản lý người dùng (danh sách, khóa/mở)
- Quản lý chi phí phát sinh (CRUD)
- Upload ảnh sản phẩm

Chi tiết endpoint: `docs/API.md`. Chi tiết bảng: `docs/DATABASE.md`.

## Ngoài phạm vi (v1.1)

- Nhà cung cấp / phiếu nhập hàng (không có trong ERD).
- Nhân viên bán hàng, POS tại quầy, đa chi nhánh.
- Thanh toán online, vận chuyển, app mobile.
- Quên mật khẩu qua email, xác thực email/SĐT.
- Sửa đơn hàng sau khi đặt (chỉ huỷ rồi đặt lại).
- Hệ thống khuyến mãi phức tạp (chỉ giảm giá theo từng sản phẩm).

## Tech stack

> **Chưa chốt** — xem `docs/DECISIONS.md` (D-002).

- Frontend: TBD
- Backend: TBD
- Database: TBD (ERD hiển thị schema `public` → gợi ý PostgreSQL, cần xác nhận)
- Môi trường dev: Windows, Node.js v24 (nếu FE dùng Node)
