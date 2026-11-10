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
| T-001 | Chốt tech stack FE/BE/DB | setup | doing | BE: ASP.NET Core ✅; DB: PostgreSQL (tạm chốt); FE: TBD |
| T-002 | Chốt phạm vi MVP & tác nhân | product | done | Theo spec v1.1 |
| T-003 | Scaffold backend ASP.NET Core | setup | done | .NET 10, packages, folders, build 0 warning/error |
| T-004 | Schema logic từ ERD | database | done | DB thật đã có — chuyển sang DB-first |
| T-005 | Route/method API | api | done | Spec v1.1, xem API.md |
| T-006 | Viết `docs/SETUP.md` | setup | done | Có lệnh chạy + scaffold DB-first |
| T-007 | Chốt câu hỏi nghiệp vụ mở | product | done | D-004…D-010 |
| T-008 | Scaffold DbContext + entities từ DB | database | done | 8 entity (gồm `RefreshToken`) + AppDbContext |
| T-009 | Đặc tả request/response body | api | todo | Ưu tiên AD-1, CUS-6, CUS-13 |
| T-010 | Scaffold frontend | setup | blocked | Chờ chọn FE stack |
| T-011 | Cấu hình DbContext + JWT + CORS + static files | setup | doing | DbContext ✅; JWT/CORS/static chưa |

## Phase 1 — Customer Module

| ID | Task | Module | Trạng thái | Ghi chú |
|---|---|---|---|---|
| T-101 | Đăng ký / đăng nhập (CUS-1,2) | auth | todo | JWT theo D-004 |
| T-102 | Danh sách + chi tiết sản phẩm (CUS-3,4) | catalog | todo | search / categoryId / sortBy |
| T-103 | Danh mục public (CUS-5) | catalog | todo | |
| T-104 | Đặt hàng (CUS-6) | order | todo | Guest + user; trừ kho theo D-005 |
| T-105 | Lịch sử + chi tiết đơn (CUS-7,8) | order | todo | Chỉ chủ đơn/Admin (D-008) |
| T-106 | Hồ sơ + đổi mật khẩu (CUS-9,10) | user | todo | |
| T-107 | Refresh token + logout (CUS-11,12) | auth | todo | Bảng `refresh_tokens` (SQL trong DATABASE.md) |
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
