# LOG — Nhật ký làm việc

> Mới nhất ở **trên**. Không sửa entry cũ, chỉ thêm entry mới.

<!-- Mẫu entry:

## YYYY-MM-DD — Tiêu đề ngắn
- **Làm:** ...
- **File:** ...
- **Quyết định:** D-xxx (nếu có)
- **Tiếp theo:** ...
- **Chặn:** ...

-->

## 2026-11-10 — Nhập yêu cầu từ Excel + Word

- **Làm:** trích đặc tả API (Customer CUS-1…10, Admin AD-0…6) từ `SnackShopManagement.xlsx` và ERD 7 bảng từ ảnh trong `SnackManagementDocuments.docx`; copy bản gốc vào `docs/specs/`.
- **File:** `docs/specs/*`, `docs/API.md`, `docs/DATABASE.md`, `docs/PROJECT.md`, `docs/TASKS.md`, `docs/STATUS.md`, `docs/DECISIONS.md`, `README.md`, `AGENTS.md`.
- **Quyết định:** D-003 (spec gốc là nguồn sự thật).
- **Tiếp theo:** T-001 chốt stack, T-007 chốt câu hỏi nghiệp vụ.
- **Chặn:** chưa có tech stack nên chưa scaffold FE/BE.

## 2026-11-10 — Khởi tạo harness

- **Làm:** dựng bộ tài liệu harness ở root để AI/dev đọc mỗi phiên.
- **File:** `AGENTS.md`, `docs/{PROJECT,STATUS,TASKS,LOG,DECISIONS,CONVENTIONS,DATABASE,API,SETUP}.md`, `.gitignore`, `.editorconfig`, `.gitattributes`, `README.md`.
- **Quyết định:** D-001 (harness là nguồn ngữ cảnh).
- **Tiếp theo:** chốt stack (T-001) và phạm vi MVP (T-002).
- **Chặn:** chưa có tech stack nên chưa scaffold FE/BE.
