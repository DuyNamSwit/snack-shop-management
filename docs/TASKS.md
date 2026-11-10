# TASKS — Việc cần làm

Trạng thái: `todo` | `doing` | `done` | `blocked`

Quy tắc:
- ID **không tái sử dụng**, task mới thêm xuống cuối.
- Mỗi phiên chỉ nên `doing` 1 task chính.
- Xong thì đổi `done` + ghi 1 dòng vào `docs/LOG.md`.

## Phase 0 — Khởi tạo

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-001 | Chốt tech stack FE/BE/DB | setup | todo | Cần user quyết (D-002) |
| T-002 | Chốt phạm vi MVP & tác nhân | product | todo | Cập nhật PROJECT.md |
| T-003 | Scaffold project `frontend/` + `backend/` | setup | blocked | Sau T-001 |
| T-004 | Thiết kế database | database | todo | Cập nhật DATABASE.md |
| T-005 | Chốt API contract | api | todo | Cập nhật API.md |
| T-006 | Viết `docs/SETUP.md` (cách chạy) | setup | blocked | Sau T-003 |

## Phase 1 — MVP (draft, chờ T-002)

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-101 | Đăng nhập + phân quyền | auth | todo | JWT hay session? |
| T-102 | CRUD danh mục + sản phẩm | product | todo | |
| T-103 | Nhập hàng + tồn kho | inventory | todo | |
| T-104 | Bán hàng (POS) + hoá đơn | sales | todo | |
| T-105 | Quản lý khách hàng | customer | todo | |
| T-106 | Báo cáo doanh thu | report | todo | |

## Phase 2 — Hoàn thiện (chưa lên kế hoạch)

- (để trống, bổ sung sau khi MVP chạy được)
