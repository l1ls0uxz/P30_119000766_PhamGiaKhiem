# P30_119000766_PhamGiaKhiem
30%
<h3>Model Category(danh mục) bao gồm các thuộc tính:</h3>
- Id
- Name (require, độ dài tối đa là 200 ký tự)
Model News(bài viết) bao gồm các thuộc tính:
- Id
- Title (require, độ dài tối đa 200, tối thiểu 50)
- ImageUrl (liên kết đến hình ảnh banner cho bài viết, require)
- Content (require, độ dài tối đa 500, tối thiểu 100)
- Author (require)
- CreatedAt
Model comment(nhận xét) gồm các thuộc tính
- Id
- Author (require)
- Content (require)
- CreatedAt
Mô tả database:
- Mỗi Category có thể chứa nhiều News, mỗi News chỉ thuộc 1 Category
- Mỗi News có thể có nhiều Comment