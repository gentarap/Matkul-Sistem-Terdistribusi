-- Membuat tabel jabatan
CREATE TABLE jabatan (
    kode_jabatan TINYINT NOT NULL PRIMARY KEY,
    nama_jabatan VARCHAR(30) NOT NULL
);

-- Membuat tabel pegawai
CREATE TABLE pegawai (
    nip CHAR(5) NOT NULL PRIMARY KEY 
        CHECK (ISNUMERIC(nip) = 1 AND LEN(nip) = 5),
    nama VARCHAR(50) NOT NULL,
    jenis_kelamin CHAR(1) NOT NULL 
        CHECK (jenis_kelamin IN ('L', 'P')),
    alamat TEXT NOT NULL,
    kode_jabatan TINYINT NOT NULL,
    FOREIGN KEY (kode_jabatan) REFERENCES jabatan(kode_jabatan)
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);
