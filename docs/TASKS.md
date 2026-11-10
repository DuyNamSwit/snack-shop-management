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
| T-002 | Chốt phạm vi MVP & tác nhân | product | done | Theo spec v1.0 |
| T-003 | Scaffold `frontend/` + `backend/` | setup | blocked | Sau T-001 |
| T-004 | Schema logic từ ERD | database | done | 7 bảng v1.0, xem DATABASE.md |
| T-005 | Route/method API | api | done | Spec v1.1, xem API.md |
| T-006 | Viết `docs/SETUP.md` | setup | blocked | Sau T-003 |
| T-007 | Chốt câu hỏi nghiệp vụ mở | product | done | Đã chốt trong spec v1.1 (D-004…D-010) |
| T-008 | Schema vật lý + migration + seed | database | blocked | Gồm 8 bảng (thêm `refresh_tokens`); sau T-001 |
| T-009 | Đặc tả request/response body | api | todo | Ưu tiên AD-1, CUS-6, CUS-13 |

## Phase 1 — Customer Module

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-101 | Đăng ký / đăng nhập (CUS-1,2) | auth | todo | JWT theo D-004 |
| T-102 | Danh sách + chi tiết sản phẩm (CUS-3,4) | catalog | todo | search / categoryId / sortBy |
| T-103 | Danh mục public (CUS-5) | catalog | todo | |
| T-104 | Đặt hàng (CUS-6) | order | todo | Guest + user; trừ kho theo D-005 |
| T-105 | Lịch sử + chi tiết đơn (CUS-7,8) | order | todo | Chỉ chủ đơn/Admin (D-008) |
| T-106 | Hồ sơ + đổi mật khẩu (CUS-9,10) | user | todo | |
| T-107 | Refresh token + logout (CUS-11,12) | auth | todo | Bảng `refresh_tokens` |
| T-108 | Tra cứu đơn vãng lai + huỷ đơn (CUS-13,14) | order | todo | Rate limit lookup; hoàn kho |

## Phase 2 — Admin Module

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-201 | Admin login + phân quyền (AD-0) | auth | todo | |
| T-202 | Dashboard báo cáo (AD-1) | report | todo | Lọc from/to/topLimit; body ở T-009 |
| T-203 | Quản lý sản phẩm (AD-2) | product | todo | CRUD + giảm giá + tồn kho |
| T-204 | Quản lý danh mục (AD-3) | category | todo | Chặn xoá nếu còn sản phẩm |
| T-205 | Quản lý đơn hàng (AD-4) | order | todo | Đổi trạng thái; huỷ → hoàn kho |
| T-206 | Quản lý người dùng (AD-5) | user | todo | Khóa/mở; không tự khoá |
| T-207 | Quản lý chi phí (AD-6) | expense | todo | |
| T-208 | Upload ảnh sản phẩm (AD-7) | upload | todo | ≤5MB, jpg/png/webp |

## Phase 3 — Hoàn thiện

- (bổ sung sau khi MVP chạy được)
