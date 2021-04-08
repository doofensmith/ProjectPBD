--membuat database
create database pbd_if19c_ww
--menggunakan database
use pbd_if19c_ww

--membuat tabel pelanggan
create table pelanggan(
KodePelanggan char(5) primary key,
NamaPelanggan varchar(25) not null,
AlamatPelanggan varchar(50) not null
)

--membuat tabel barang
create table barang(
KodeBarang char(5) primary key,
NamaBarang varchar(25) not null,
HargaBarang int not null,
StokBarang int not null,
Satuan varchar(15) not null
)

--membuat tabel kwitansi
create table kwitansi(
NomorKwitansi char(5) primary key,
TanggalKwitansi date not null,
KodePelanggan char(5) not null foreign key references pelanggan(KodePelanggan)
)

--membuat tabel detail kwitansi
create table detail_kwitansi(
NomorKwitansi char(5) not null foreign key references kwitansi(NomorKwitansi),
KodeBarang char(5) not null foreign key references barang(KodeBarang),
jumlahjual int not null
)

--memasukkan data pelanggan
insert into pelanggan values
('P0001','aditya','Bandar Lampung'),
('P0002','nandi','Lampung Barat'),
('P0003','indrajat','Lampung Selatan'),
('P0004','ali','Bandar Lampung'),
('P0005','agung p','Lampung Selatan'),
('P0006','dedi','Lampung Selatan'),
('P0007','rhendy','Lampung Selatan'),
('P0008','lulus','Lampung Timur'),
('P0009','alipi','Bandar Lampung'),
('P0010','indra','Bandar Lampung')

--memasukkan data barang
bulk insert barang
from 'D:\Wahyu\Kuliah\Semester 4\Pemrograman Basis Data\modul\data_barang.csv'
with(
firstrow = 2,
fieldterminator = ',',
rowterminator = '\n'
)
go

--select pelanggan dan barang
select * from pelanggan;
select * from barang;

--membuat view kwitansi
create view View_Kwitansi as
select detail_kwitansi.NomorKwitansi, kwitansi.TanggalKwitansi,
pelanggan.KodePelanggan, pelanggan.NamaPelanggan,
detail_kwitansi.KodeBarang, barang.NamaBarang, barang.HargaBarang,
barang.Satuan, detail_kwitansi.jumlahjual
from detail_kwitansi
join kwitansi
on kwitansi.NomorKwitansi = detail_kwitansi.NomorKwitansi
join barang
on barang.KodeBarang = detail_kwitansi.KodeBarang
join pelanggan
on pelanggan.KodePelanggan = kwitansi.KodePelanggan

--memasukkan daa kwitansi
insert into kwitansi values
('K0001','2018/03/01','P0001'),
('K0002','2018/03/05','P0002'),
('K0003','2018/03/07','P0003'),
('K0004','2018/03/07','P0004')

--memasukkan data detail kwitansi
insert into detail_kwitansi values
('K0001','B0001',2),
('K0001','B0002',1),
('K0001','B0004',1),
('K0002','B0002',1),
('K0003','B0001',2),
('K0003','B0002',1),
('K0003','B0003',1),
('K0003','B0004',3),
('K0004','B0001',1),
('K0004','B0004',1)

--memanggil view
select * from View_Kwitansi

--membuat view detail kwitansi
create view view_detailkwitansi as
select detail_kwitansi.NomorKwitansi, detail_kwitansi.KodeBarang,
barang.NamaBarang, barang.HargaBarang, detail_kwitansi.jumlahjual,
barang.HargaBarang * detail_kwitansi.jumlahjual as JumlahBayar
from barang
inner join detail_kwitansi
on barang.KodeBarang = detail_kwitansi.KodeBarang

--memanggil view
select * from view_detailkwitansi

--prosedure sp_view_kwitansi
create procedure SP_View_Kwitansi as
begin
	select * from View_Kwitansi;
end;

--execute proc sp_view_kwitnsi
execute SP_View_Kwitansi;

--membuat prosedur simpan_pelanggan
create procedure simpan_pelanggan
@kdpelanggan char(5),
@nmpelanggan varchar(25),
@almtpelanggan varchar(50)
as
begin
	insert into pelanggan values
	(@kdpelanggan, @nmpelanggan, @almtpelanggan);
end;

--ekseskusi prosedur simpan pelanggan
execute simpan_pelanggan 'P0035','Alzi','Bandar Lampung';
select * from pelanggan;

--prosedur hapus peangan
create procedure hapus_pelanggan
@kdpelanggan char(5)
as
begin
	delete from pelanggan where KodePelanggan = @kdpelanggan;
end;

--eksesui prosedur haps pelanggan
execute hapus_pelanggan 'P0035';
select * from pelanggan;

--prosedur ubah_pelanggan
create procedure ubah_pelanggan
@kdpelanggan char(5),
@nmpelanggan varchar(25),
@almtpelanggan varchar(50)
as
begin
	update pelanggan set NamaPelanggan = @nmpelanggan,
	AlamatPelanggan = @almtpelanggan
	where KodePelanggan = @kdpelanggan;
end;

--eksekusi prosedur ubag_pelanggan
execute ubah_pelanggan 'P0030','anita','Lampung Barat';
select * from pelanggan;

--prosedur cari_pelanggan
create procedure cari_pelanggan
@nmpelanggan varchar(25)
as
begin
	select * from pelanggan
	where NamaPelanggan like '%'+@nmpelanggan+'%';
end;

--cari nma pelanggan yang menganung huruf e
execute cari_pelanggan 'E';

--prosedur simpan_barang
create procedure simpan_barang
@kdbarang char(5),
@nmbarang varchar(25),
@hrgbarang int,
@stok int,
@satuan varchar(15)
as
begin
	insert into barang values
	(@kdbarang, @nmbarang, @hrgbarang, @stok, @satuan);
end;

--eksekusi prow simpan_barang
execute simpan_barang 'B0008','Mouse Log',650000,49,'pcs';
execute simpan_barang 'B0009','Keyboard Razor',750000,50,'pcs';
select * from barang;

--prosedur aps barang
create procedure hapus_barang
@kodebarang char(5)
as
begin
	delete from barang where KodeBarang = @kodebarang;
end;

--skeusi proc hapus barang
execute hapus_barang 'B0009';
select * from barang;

--prosedur ubah barang
create procedure ubah_barang
@nama varchar(25),
@harga int,
@stok int,
@satuan varchar(15),
@kode char(5)
as
begin
	update barang set
	NamaBarang = @nama,
	HargaBarang = @harga,
	StokBarang = @stok,
	Satuan = @satuan
	where KodeBarang = @kode;
end;

--eksekusi proc ubang barang
execute ubah_barang 'Handphone X5',4500000,100,'pcs','B0008';
select * from barang;

--prosedir cari barang
create procedure cari_barang
@namabarang varchar(25)
as
begin
	select * from barang
	where NamaBarang like '%'+@namabarang+'%';
end;

--eksesusi cari barang mengandung huruf j
execute cari_barang 'J';

--proc simpan kwitansi
create procedure simpan_kwitansi
@nokwitansi char(5),
@tanggal date,
@kodepelanggan char(5)
as
begin
	insert into kwitansi values
	(@nokwitansi,@tanggal,@kodepelanggan);
end;

--ekseskusi simpan kwitansi
execute simpan_kwitansi 'K0005','2018/03/20','P0001';
select * from kwitansi;

--prosedur simpan detail kwitans
create procedure simpan_detailkwitansi
@nokwitansi char(5),
@kodebarang char(5),
@jumlah int
as
begin
	insert into detail_kwitansi values
	(@nokwitansi, @kodebarang, @jumlah);
end;

--eksekusi proc seimapn dtail kwitansi
execute simpan_detailkwitansi 'K0005','B0001',2;
select * from detail_kwitansi;

--proc hapus detal kwitansi
create procedure hapus_detailkwitansi
@nokwitansi char(5),
@kodebarang char(5)
as
begin
	delete from detail_kwitansi
	where NomorKwitansi = @nokwitansi and
	KodeBarang = @kodebarang;
end;

--eksekusi proc hapus detl kwitansi
execute hapus_detailkwitansi 'K0005','B0001';
select * from detail_kwitansi;

--membuat trigger afterinsert detailkwitansi
create trigger AfterInsert_DetailKwitansi
on detail_kwitansi
after insert
as
begin
	declare
		@jumlah int,
		@kode char(5)
	select @jumlah = jumlahjual,
	@kode = KodeBarang from inserted

	update barang set
	barang.StokBarang = barang.StokBarang - @jumlah
	where barang.KodeBarang = @kode;
end;

--coba trigger
--simpan data ke tabel detail kwitansi
execute simpan_detailkwitansi 'K0005','B0002',9;
--cek stok barang
select * from barang;

--membuat trigger afterdelete detailkwitansi
create trigger AfterDelete_DetailKwitansi
on detail_kwitansi
after delete
as
begin
	declare
		@jumlah int,
		@kode char(5)
	select @jumlah = jumlahjual,
	@kode = KodeBarang from deleted

	update barang set
	barang.StokBarang = barang.StokBarang + @jumlah
	where barang.KodeBarang = @kode;
end;

--coba trigger
--hapus data dari tabel detil kewitansi
execute hapus_detailkwitansi 'K0005','B0002';
--cek stk barang
select * from barang;

--membuat tabel login
create table tbl_login(
username varchar(25) primary key,
password varchar(25) not null
);

--membuat tabel log login
create table log_tbl_login(
username varchar(25) not null,
user_status varchar(10) not null,
date_status datetime default getdate()
);

--trigger insert login
create trigger insert_login
on tbl_login
after insert
as
begin
	declare
		@user varchar(25)
	select @user = username from inserted

	insert into log_tbl_login(username,user_status) values
	(@user, 'REGISTERED');
end;

--simpan 1 user ke tbl_login
insert into tbl_login values
('ww_test','testpw123');
--cek data di tabel log tbl login
select * from log_tbl_login;
