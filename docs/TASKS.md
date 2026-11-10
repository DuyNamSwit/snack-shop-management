# TASKS — Việc cần làm

Trạng thái: `todo` | `doing` | `done` | `blocked`

Quy tắc:
- ID **không tái sử dụng**, task mới thêm xuống cuối.
- Mỗi phiên chỉ nên `doing` 1 task chính.
- Thứ tự làm mỗi task: chốt DB/API → viết BE → nối FE → user test tay.
- Xong thì đổi `done` + ghi 1 dòng vào `docs/LOG.md`.

## Phase 0 — Setup

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-001 | Chốt tech stack FE/BE/DB | setup | todo | User quyết (D-002) |
| T-002 | Chốt phạm vi MVP & tác nhân | product | done | Theo 2 file spec, xem PROJECT.md |
| T-003 | Scaffold `frontend/` + `backend/` | setup | blocked | Sau T-001 |
| T-004 | Schema logic từ ERD | database | done | 7 bảng, xem DATABASE.md |
| T-005 | Route/method API từ spec | api | done | Xem API.md |
| T-006 | Viết `docs/SETUP.md` | setup | blocked | Sau T-003 |
| T-007 | Chốt câu hỏi nghiệp vụ mở | product | todo | 5 câu trong DATABASE.md |
| T-008 | Schema vật lý + migration + seed | database | blocked | Sau T-001, T-007 |
| T-009 | Đặc tả request/response body | api | todo | Sau T-007 |

## Phase 1 — Customer Module

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-101 | Đăng ký / đăng nhập (CUS-1,2) | auth | todo | JWT? chờ T-007 |
| T-102 | Danh sách + chi tiết sản phẩm (CUS-3,4) | catalog | todo | search / categoryId / sortBy |
| T-103 | Danh mục public (CUS-5) | catalog | todo | |
| T-104 | Đặt hàng (CUS-6) | order | todo | Guest + user; trừ kho lúc nào? |
| T-105 | Lịch sử + trạng thái đơn (CUS-7,8) | order | todo | Cần chặn xem đơn người khác |
| T-106 | Hồ sơ + đổi mật khẩu (CUS-9,10) | user | todo | |

## Phase 2 — Admin Module

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-201 | Admin login + phân quyền (AD-0) | auth | todo | |
| T-202 | Dashboard báo cáo (AD-1) | report | todo | doanh thu, vốn, chi phí, lợi nhuận, top |
| T-203 | Quản lý sản phẩm (AD-2) | product | todo | CRUD + giảm giá + tồn kho |
| T-204 | Quản lý danh mục (AD-3) | category | todo | |
| T-205 | Quản lý đơn hàng (AD-4) | order | todo | đổi trạng thái |
| T-206 | Quản lý người dùng (AD-5) | user | todo | khóa / mở |
| T-207 | Quản lý chi phí (AD-6) | expense | todo | |

## Phase 3 — Hoàn thiện

- (bổ sung sau khi MVP chạy được)
