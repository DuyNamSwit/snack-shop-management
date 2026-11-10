# AGENTS.md — Luật chơi cho AI

> Đọc file này **đầu tiên** trong mọi phiên làm việc. Đây là điểm vào của "harness" — bộ tài liệu giúp AI biết dự án đang ở đâu và làm gì tiếp theo mà không quên ngữ cảnh.

## 1. Bối cảnh

- **Dự án:** Snack Shop Management — website quản lý cửa hàng bánh kẹo / đồ ăn vặt.
- **Hình thức:** dự án cá nhân (1 dev + AI hỗ trợ).
- **Ngôn ngữ:** trao đổi và tài liệu bằng tiếng Việt; code / commit message bằng tiếng Anh.
- **Phong cách:** KISS — ít code, dễ hiểu, chạy được. Không thêm abstraction hay tính năng ngoài yêu cầu. User tự test tay.
- **Code chính:** `frontend/` và `backend/` (hiện đang trống — xem `docs/STATUS.md`).

## 2. Harness — nguồn sự thật

| File | Trả lời câu hỏi | Đọc khi | Ghi khi |
|---|---|---|---|
| `docs/STATUS.md` | "Đang ở đâu?" | Đầu phiên | Cuối phiên |
| `docs/TASKS.md` | "Làm gì tiếp?" | Đầu phiên | Mỗi khi task đổi trạng thái |
| `docs/LOG.md` | "Đã làm gì?" | Đầu phiên (3 entry mới nhất) | Cuối phiên (thêm entry) |
| `docs/DECISIONS.md` | "Vì sao thiết kế như vậy?" | Trước khi đổi kiến trúc / nghiệp vụ | Khi có quyết định |
| `docs/PROJECT.md` | "Dự án làm gì?" | Khi cần hiểu scope | Khi scope đổi |
| `docs/DATABASE.md` | "Dữ liệu gồm những gì?" | Khi làm DB / entity | Khi schema đổi |
| `docs/API.md` | "FE gọi BE thế nào?" | Khi làm API / FE | Khi endpoint đổi |
| `docs/CONVENTIONS.md` | "Viết code theo chuẩn nào?" | Trước khi viết code | Khi chuẩn đổi |
| `docs/specs/*` | "Yêu cầu gốc là gì?" | Khi cần đối chiếu spec | **Không sửa** — đây là file gốc của user |

Nếu tài liệu và code mâu thuẫn: **code là sự thật hiện tại**, nhưng phải sửa lại tài liệu cho khớp ngay trong phiên đó. Nếu code/tài liệu mâu thuẫn với `docs/specs/`: **spec thắng** — code lệch spec là bug.

## 3. Quy trình mỗi phiên

**Bắt đầu:**
1. Đọc `docs/STATUS.md`.
2. Đọc `docs/TASKS.md`.
3. Đọc 3 entry mới nhất trong `docs/LOG.md`.

**Trong khi làm:**
- Bám đúng task trong `TASKS.md`. Task mơ hồ → hỏi user, không tự suy diễn nghiệp vụ.
- Đổi schema → cập nhật `DATABASE.md`. Thêm/sửa endpoint → cập nhật `API.md`.
- Quyết định kỹ thuật / nghiệp vụ quan trọng → thêm dòng vào `DECISIONS.md`.

**Kết thúc:**
1. Cập nhật `docs/STATUS.md` (đang ở đâu, tiếp theo, đang chặn).
2. Cập nhật trạng thái trong `docs/TASKS.md`.
3. Thêm 1 entry mới lên **đầu** `docs/LOG.md`.
4. Chỉ commit khi user yêu cầu.

## 4. Luật bất di bất dịch

- Không tự đổi scope hoặc chọn công nghệ thay user — chưa chốt thì ghi vào mục "Cần user quyết" của `STATUS.md`.
- `docs/specs/` là bản gốc của user: chỉ đọc, không sửa. Muốn đổi nghiệp vụ → hỏi user và ghi quyết định mới vào `DECISIONS.md`.
- Không sửa entry cũ trong `LOG.md`; chỉ thêm mới.
- Không chạy lệnh phá huỷ (reset --hard, xoá DB, rm -rf...) khi chưa được phép.
- Không commit / push khi user chưa yêu cầu.
- Code xong phải build / chạy được; phần UI để user tự test tay.

## 5. Định nghĩa "xong" (Definition of Done)

- [ ] Code build / chạy không lỗi.
- [ ] Đúng yêu cầu task, không phát sinh ngoài scope.
- [ ] `DATABASE.md` / `API.md` đã cập nhật nếu có thay đổi.
- [ ] `STATUS.md` + `TASKS.md` + `LOG.md` đã cập nhật.

## 6. Prompt mẫu cho user

```
Đọc AGENTS.md và docs/STATUS.md, cho tôi biết dự án đang ở đâu và
3 việc tiếp theo cần làm. Sau đó làm task <ID>.
```
