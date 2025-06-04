-- 1. Tạo database
CREATE DATABASE PhongKham;
USE PhongKham;

-- 2. Bảng BENHNHAN
CREATE TABLE BENHNHAN (
    MaBenhNhan VARCHAR(10) PRIMARY KEY,
    HoTen VARCHAR(100),
    GioiTinh VARCHAR(10),
    NamSinh INT,
    DiaChi VARCHAR(255)
);

-- 3. Bảng THAMSO
CREATE TABLE THAMSO (
    SoLuongBenhNhanToiDaTrongNgay INT,
    QuyDinhSoLuongBenhNhanToiDaTrongNgay BOOLEAN,
    TienKhamCoDinh DECIMAL(10,2),
    QuyDinhTienKhamCoDinh BOOLEAN
);

-- 4. Bảng LOAIBENH
CREATE TABLE LOAIBENH (
    MaLoaiBenh VARCHAR(10) PRIMARY KEY,
    TenLoaiBenh VARCHAR(100)
);

-- 5. Bảng KHAMBENH
CREATE TABLE KHAMBENH (
    MaKhamBenh VARCHAR(10) PRIMARY KEY,
    NgayKham DATE,
    MaBenhNhan VARCHAR(10),
    TrieuChung TEXT,
    MaLoaiBenh VARCHAR(10),
    FOREIGN KEY (MaBenhNhan) REFERENCES BENHNHAN(MaBenhNhan),
    FOREIGN KEY (MaLoaiBenh) REFERENCES LOAIBENH(MaLoaiBenh)
);

-- 6. Bảng DONVI
CREATE TABLE DONVI (
    MaDonVi VARCHAR(10) PRIMARY KEY,
    TenDonVi VARCHAR(100)
);

-- 7. Bảng CACHDUNG
CREATE TABLE CACHDUNG (
    MaCachDung VARCHAR(10) PRIMARY KEY,
    TenCachDung VARCHAR(100)
);


-- 8. Bảng LOAITHUOC
CREATE TABLE LOAITHUOC (
    MaLoaiThuoc VARCHAR(10) PRIMARY KEY,
    TenLoaiThuoc VARCHAR(100),
    MaDonVi VARCHAR(10),
    MaCachDung VARCHAR(10),
	DonGia DECIMAL(10,2),
    FOREIGN KEY (MaDonVi) REFERENCES DONVI(MaDonVi),
    FOREIGN KEY (MaCachDung) REFERENCES CACHDUNG(MaCachDung)
);

-- 9. Bảng CTKHAMBENH
CREATE TABLE CTKHAMBENH (
    MaKhamBenh VARCHAR(10),
    MaLoaiThuoc VARCHAR(10),
    SoLuongThuoc INT,
    PRIMARY KEY (MaKhamBenh, MaLoaiThuoc),
    FOREIGN KEY (MaKhamBenh) REFERENCES KHAMBENH(MaKhamBenh),
    FOREIGN KEY (MaLoaiThuoc) REFERENCES LOAITHUOC(MaLoaiThuoc)
);

-- 10. Bảng HOADON
CREATE TABLE HOADON (
    MaHoaDon VARCHAR(10) PRIMARY KEY,
    TienKham DECIMAL(10,2),
    TienThuoc DECIMAL(10,2),
    MaKhamBenh VARCHAR(10),
    FOREIGN KEY (MaKhamBenh) REFERENCES KHAMBENH(MaKhamBenh)
);

-- 11 Dữ liệu mẫu
INSERT INTO DONVI (MaDonVi, TenDonVi) VALUES
('DV001', 'Viên'),
('DV002', 'Chai'),
('DV003', 'Ống');
INSERT INTO CACHDUNG (MaCachDung, TenCachDung) VALUES
('CD001', 'Uống sau ăn'),
('CD002', 'Bôi ngoài da'),
('CD003', 'Tiêm tĩnh mạch');
INSERT INTO LOAITHUOC (MaLoaiThuoc, TenLoaiThuoc, MaDonVi, MaCachDung, DonGia) VALUES
('LT001', 'Paracetamol', 'DV001', 'CD001', 3000),
('LT002', 'Vitamin C', 'DV001', 'CD001', 2000),
('LT003', 'Kem bôi da', 'DV002', 'CD002', 5000);
INSERT INTO LOAIBENH (MaLoaiBenh, TenLoaiBenh) VALUES
('LB001', 'Cảm cúm'),
('LB002', 'Viêm họng'),
('LB003', 'Đau dạ dày');
INSERT INTO BENHNHAN (MaBenhNhan, HoTen, GioiTinh, NamSinh, DiaChi) VALUES
('BN001', 'Nguyễn Văn A', 'Nam', 1990, 'Hà Nội'),
('BN002', 'Trần Thị B', 'Nữ', 1985, 'TP. HCM'),
('BN003', 'Lê Văn C', 'Nam', 2002, 'Huế');
INSERT INTO KHAMBENH (MaKhamBenh, NgayKham, MaBenhNhan, TrieuChung, MaLoaiBenh) VALUES
('KB001', '2025-05-30', 'BN001', 'Sốt, ho, mệt mỏi', 'LB001'),
('KB002', '2025-05-30', 'BN002', 'Đau họng, khàn tiếng', 'LB002'),
('KB003', '2025-05-30', 'BN003', 'Đau bụng, buồn nôn', 'LB003');
INSERT INTO CTKHAMBENH (MaKhamBenh, MaLoaiThuoc, SoLuongThuoc) VALUES
('KB001', 'LT001', 10),
('KB001', 'LT002', 5),
('KB002', 'LT001', 8),
('KB003', 'LT003', 2);
INSERT INTO HOADON (MaHoaDon, TienKham, TienThuoc, MaKhamBenh) VALUES
('HD001', 100000, 50000, 'KB001'),
('HD002', 100000, 24000, 'KB002'),
('HD003', 100000, 10000, 'KB003');
INSERT INTO KHAMBENH (MaKhamBenh, NgayKham, MaBenhNhan, TrieuChung, MaLoaiBenh)
VALUES ('KB004', '2025-05-31', 'BN001', 'Đau đầu, chóng mặt', 'LB002');  -- LB002 = Viêm họng
INSERT INTO THAMSO (SoLuongBenhNhanToiDaTrongNgay, QuyDinhSoLuongBenhNhanToiDaTrongNgay, TienKhamCoDinh, QuyDinhTienKhamCoDinh)
VALUES (50, TRUE, 100000, TRUE);
SET SQL_SAFE_UPDATES = 0;
UPDATE THAMSO
SET
    QuyDinhSoLuongBenhNhanToiDaTrongNgay = TRUE,
    QuyDinhTienKhamCoDinh = TRUE;
UPDATE THAMSO
SET
	SoLuongBenhNhanToiDaTrongNgay = 40,
    TienKhamCoDinh=300000;
