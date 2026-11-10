# CONVENTIONS — Quy ước code

> Phần lớn sẽ chốt cụ thể sau khi có stack (T-001). Dưới đây là các quy ước áp dụng ngay.

## Git

- Nhánh chính: `main`. Làm feature trên nhánh `feat/<ten-ngan>` nếu thay đổi lớn.
- Commit theo Conventional Commits: `feat:`, `fix:`, `refactor:`, `docs:`, `chore:`, `test:`.
- Commit message tiếng Anh, ngắn, tập trung vào **why**.
- Không commit `node_modules/`, `bin/`, `obj/`, `dist/`, `.env`, file DB local.
- Chỉ commit khi user yêu cầu.

## Code

- KISS: không tạo abstraction / tầng trung gian khi chưa có nhu cầu thực tế.
- Comment chỉ khi giải thích **why** (ràng buộc ẩn, workaround), không giải thích **what**.
- Tên biến/hàm rõ nghĩa, không viết tắt khó hiểu.
- Không để code chết, không giữ lại code cũ "để tham khảo".

## API (đề xuất — chốt ở T-005)

- REST, prefix `/api/v1`.
- Thành công: `{ "success": true, "data": ..., "message": "..." }`
- Lỗi: `{ "success": false, "message": "...", "errors": [...] }`
- Status code: 400 validate, 401 chưa đăng nhập, 403 không có quyền, 404 không thấy, 409 trùng dữ liệu, 500 lỗi server.
- Ngày giờ: ISO 8601 (UTC).
- FE gọi API qua 1 lớp service duy nhất, không rải `fetch` trong component.

## Database

- Bảng: snake_case, số nhiều (`products`, `order_items`).
- Mọi bảng có `id`, `created_at`, `updated_at`.
- Mặc định xoá cứng; chỉ dùng xoá mềm (`deleted_at`) khi nghiệp vụ cần lưu lịch sử.
- Khoá ngoại đặt tên `<bang>_id` (`category_id`, `order_id`).
- Mọi thay đổi schema phải cập nhật `docs/DATABASE.md` trong cùng phiên.

## Frontend

- Component: PascalCase (`ProductCard.tsx`), file khác camelCase.
- Tách `pages/`, `components/`, `services/`, `types/`.
- Không hardcode URL API — dùng biến môi trường (`VITE_API_URL` hoặc tương đương).

## Backend

- Controller/route mỏng, logic nghiệp vụ đặt trong service (chốt lại theo stack).
- Validate input ở biên (API), không tin dữ liệu từ client.
- Không trả stack trace / thông tin nội bộ ra response lỗi.
