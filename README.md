# MotoVibe

Welcome to **MotoVibe**! This guide will help you work with GitHub for effective collaboration on this project.

---

## 🚀 English Version

### 1️⃣ Prerequisites
Ensure you have the following installed:
- **Git** (https://git-scm.com/)
- **GitHub Account** (https://github.com/)

### 2️⃣ Clone the Repository
To get a local copy of the project, run:
```sh
git clone https://github.com/hungtqce180632/MotoVibe.git
```
Then, navigate to the project folder:
```sh
cd MotoVibe
```

### 3️⃣ Working with Branches
We use branches to manage development effectively:
- `main` → Stable production-ready code
- `development` → Active development branch
- `feature-xyz` → Branch for specific features

To create a new branch:
```sh
git checkout -b feature-your-feature-name
```

### 4️⃣ Making Changes and Pushing Code
After making changes, stage and commit them:
```sh
git add .
git commit -m "Describe your changes"
```
Push your changes to GitHub:
```sh
git push origin feature-your-feature-name
```

### 5️⃣ Creating a Pull Request (PR)
1. Go to the repository on GitHub.
2. Click on 'Compare & pull request' for your branch.
3. Provide a clear description of your changes.
4. Submit the PR for review.

### 6️⃣ Reviewing and Merging PRs
- PRs must be reviewed before merging.
- If requested, make changes and push them again.
- Once approved, merge the PR.

### 7️⃣ Keeping Your Branch Updated
Before pushing new changes, always update your branch:
```sh
git checkout main
git pull origin main
git checkout feature-your-feature-name
git rebase main
```
This prevents conflicts and ensures your work is up-to-date.

### 8️⃣ Reporting Issues
If you find a bug or have a feature request, create an **Issue** on GitHub.

---

## 🇻🇳 Phiên bản Tiếng Việt

### 1️⃣ Điều kiện tiên quyết
Hãy đảm bảo bạn đã cài đặt các công cụ sau:
- **Git** (https://git-scm.com/)
- **Tài khoản GitHub** (https://github.com/)

### 2️⃣ Sao chép kho lưu trữ (Clone Repository)
Chạy lệnh sau để sao chép dự án về máy:
```sh
git clone https://github.com/hungtqce180632/MotoVibe.git
```
Sau đó, di chuyển vào thư mục dự án:
```sh
cd MotoVibe
```

### 3️⃣ Làm việc với nhánh (Branch)
Chúng tôi sử dụng các nhánh để quản lý phát triển:
- `main` → Mã ổn định, sẵn sàng cho sản phẩm
- `development` → Nhánh phát triển chính
- `feature-xyz` → Nhánh cho các tính năng riêng lẻ

Tạo một nhánh mới:
```sh
git checkout -b feature-your-feature-name
```

### 4️⃣ Chỉnh sửa và đẩy mã nguồn (Commit & Push)
Sau khi chỉnh sửa, thêm và cam kết thay đổi:
```sh
git add .
git commit -m "Mô tả thay đổi của bạn"
```
Đẩy mã lên GitHub:
```sh
git push origin feature-your-feature-name
```

### 5️⃣ Tạo yêu cầu hợp nhất (Pull Request - PR)
1. Truy cập kho lưu trữ trên GitHub.
2. Nhấn vào 'Compare & pull request' cho nhánh của bạn.
3. Cung cấp mô tả rõ ràng về thay đổi.
4. Gửi yêu cầu PR để xem xét.

### 6️⃣ Xem xét và hợp nhất PRs
- PR cần được xem xét trước khi hợp nhất.
- Nếu có yêu cầu chỉnh sửa, hãy thực hiện và đẩy lại.
- Sau khi được chấp thuận, hợp nhất PR.

### 7️⃣ Cập nhật nhánh của bạn
Trước khi đẩy thay đổi mới, luôn cập nhật nhánh của bạn:
```sh
git checkout main
git pull origin main
git checkout feature-your-feature-name
git rebase main
```
Điều này giúp tránh xung đột và đảm bảo mã của bạn luôn mới nhất.

### 8️⃣ Báo cáo lỗi
Nếu bạn phát hiện lỗi hoặc có yêu cầu tính năng, hãy tạo **Issue** trên GitHub.

---
