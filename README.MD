# PROJECT: Bestora E-Commerce Platform

Bestora là nền tảng thương mại điện tử đa chức năng, phát triển trên ABP Framework (.NET 9), PostgreSQL, Redis và Angular 19.

## 1. Cấu trúc thư mục
Bestora/ ├── admin-app/ # Frontend quản trị (ABP Angular Template) ├── customer-app/ # Frontend khách hàng (Angular, NG-ZORRO) ├── aspnet-core/ # Backend (ABP, .NET 9, PostgreSQL, Redis)


## 2. Yêu cầu môi trường

- .NET SDK 9
- Node.js >= 18.x
- Yarn hoặc NPM
- Angular CLI >= 17.x
- PostgreSQL >= 14
- Redis
- ABP CLI: `dotnet tool install -g Volo.Abp.Cli`

## 3. Thiết lập & Khởi tạo

### 3.1. Clone & Cài đặt

- Clone repo về máy
- Cài đặt các tool và package cần thiết
  - `yarn install` hoặc `npm install` trong từng frontend app

### 3.2. Cấu hình database & migrate

- Sửa connection string trong `aspnet-core/src/Bestora.DbMigrator/appsettings.json`
- Chạy migrate và seed database:
  ```bash
  cd aspnet-core/src/Bestora.DbMigrator
  dotnet run
3.3. Chạy backend
bash
cd aspnet-core/src/Bestora.HttpApi.Host
dotnet run
Truy cập Swagger: http://localhost:44335/swagger
3.4. Chạy frontend
Admin-app:
bash
cd admin-app
yarn start
Truy cập: http://localhost:4200
Customer-app:
bash
cd customer-app
yarn start
Truy cập: http://localhost:4200 (hoặc port khác nếu trùng)
3.5. Tài khoản mặc định
Username: admin
Password: 1q2w3E*
4. Development Flow & Conventions
Mỗi frontend là một project Angular RIÊNG BIỆT, không lồng trong src của nhau.
Backend và frontend phát triển song song, giao tiếp qua API.
Customer-app ban đầu dùng mock data, sau đó tích hợp API thật bằng proxy ABP.
Sử dụng git flow chuẩn: main, dev, feature/bugfix branches.
Tên thư mục, file, biến: tiếng Anh, rõ ràng, đúng chức năng.
C# theo chuẩn Microsoft, Angular theo Angular style guide.
Không sửa file proxy API bằng tay.
5. Useful Commands
Generate ABP proxy service (customer-app):
bash
npx ng g @abp/ng.schematics:proxy --module app --url https://localhost:44335
6. Angular CLI Quick Guide
Development server
Run ng serve for a dev server. Navigate to http://localhost:4200/. The app will automatically reload if you change any of the source files.

Code scaffolding
Run ng generate component component-name to generate a new component. You can also use ng generate directive|pipe|service|class|guard|interface|enum|module.

Build
Run ng build to build the project. The build artifacts will be stored in the dist/ directory. Use the --prod flag for a production build.

Running unit tests
Run ng test to execute the unit tests via Karma.

Running end-to-end tests
Run ng e2e to execute the end-to-end tests via a platform of your choice.

7. Tài liệu tham khảo
ABP Framework
Angular
NG-ZORRO
Nếu bạn là thành viên mới, vui lòng đọc kỹ file này trước khi bắt đầu phát triển!