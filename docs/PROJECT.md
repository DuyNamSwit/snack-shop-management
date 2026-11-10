# PROJECT — Snack Shop Management

## Mục tiêu

Website bán bánh kẹo / đồ ăn vặt, gồm 2 phần: khách hàng đặt hàng online và admin quản trị cửa hàng.

## Nguồn yêu cầu

- `docs/specs/SnackShopManagement.xlsx` — đặc tả API (Customer + Admin).
- `docs/specs/SnackManagementDocuments.docx` — ERD "Cấu trúc các bảng trong database".

Hai file này là **nguồn sự thật**; tài liệu trong `docs/` phải khớp với chúng.

## Hình thức

Dự án cá nhân — 1 dev (chủ dự án) + AI hỗ trợ.

## Tác nhân

| Tác nhân | Quyền chính |
|---|---|
| Khách hàng (Customer) | Đăng ký / đăng nhập, xem sản phẩm & danh mục, đặt hàng (kể cả vãng lai), xem lịch sử & trạng thái đơn, sửa hồ sơ, đổi mật khẩu |
| Quản trị viên (Admin) | Đăng nhập riêng, xem dashboard báo cáo, quản lý sản phẩm / danh mục / đơn hàng / người dùng / chi phí |

## Phạm vi MVP (đã chốt theo spec)

**Customer Module** — 10 chức năng:
- Đăng ký, đăng nhập
- Xem danh sách / chi tiết sản phẩm, lọc & sắp xếp
- Xem danh mục
- Đặt hàng (đã đăng nhập hoặc vãng lai)
- Lịch sử đơn, xem trạng thái đơn
- Cập nhật hồ sơ, đổi mật khẩu

**Admin Module** — 7 nhóm chức năng:
- Đăng nhập admin
- Dashboard báo cáo (doanh thu, tiền vốn, chi phí, lợi nhuận, top bán chạy)
- Quản lý sản phẩm (CRUD + giảm giá + tồn kho)
- Quản lý danh mục (CRUD)
- Quản lý đơn hàng (danh sách, chi tiết, đổi trạng thái)
- Quản lý người dùng (danh sách, khóa/mở)
- Quản lý chi phí phát sinh (CRUD)

Chi tiết endpoint: `docs/API.md`. Chi tiết bảng: `docs/DATABASE.md`.

## Ngoài phạm vi (theo spec hiện tại)

- Nhà cung cấp / phiếu nhập hàng (không có trong ERD).
- Nhân viên bán hàng, POS tại quầy, đa chi nhánh.
- Thanh toán online, vận chuyển, app mobile.
- Hệ thống khuyến mãi phức tạp (chỉ giảm giá theo từng sản phẩm).

## Tech stack

> **Chưa chốt** — xem `docs/DECISIONS.md` (D-002).

- Frontend: TBD
- Backend: TBD
- Database: TBD (ERD hiển thị schema `public` → gợi ý PostgreSQL, cần xác nhận)
- Môi trường dev: Windows, Node.js v24 (nếu FE dùng Node)
