# PROJECT — Snack Shop Management

## Mục tiêu

Website quản lý cửa hàng bánh kẹo / đồ ăn vặt: quản lý sản phẩm, tồn kho, bán hàng, khách hàng và báo cáo.

## Hình thức

Dự án cá nhân — 1 dev (chủ dự án) + AI hỗ trợ. Không ràng buộc deadline đồ án nhóm.

## Tác nhân (draft — chờ chốt T-002)

| Tác nhân | Mô tả | Quyền chính |
|---|---|---|
| Chủ cửa hàng (Admin) | Toàn quyền hệ thống | Quản lý sản phẩm, nhân viên, xem báo cáo |
| Nhân viên bán hàng | Vận hành hằng ngày | Bán hàng (POS), nhập hàng, xem tồn kho |
| Khách hàng | (tuỳ chọn) Mua online | Xem sản phẩm, đặt hàng — chưa chắc có trong MVP |

## Phạm vi MVP (draft — chờ chốt T-002)

- [ ] Đăng nhập + phân quyền
- [ ] Quản lý danh mục + sản phẩm
- [ ] Quản lý tồn kho + phiếu nhập hàng
- [ ] Bán hàng (POS) + hoá đơn
- [ ] Quản lý khách hàng
- [ ] Báo cáo doanh thu

## Ngoài phạm vi (draft)

- Thanh toán online, giao hàng, khuyến mãi phức tạp, đa chi nhánh, app mobile.

## Tech stack

> **Chưa chốt** — xem `docs/DECISIONS.md` (D-002).

- Frontend: TBD
- Backend: TBD
- Database: TBD
- Chạy local trên Windows; Node.js v24 đã có sẵn (nếu FE dùng Node).

## Cấu trúc repo

```
frontend/   # FE
backend/    # BE
docs/       # harness
```
