using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Db_mahasiswa
{
    #region Mhs
    public class Mhs
    {
        #region Member Variables
        protected int _nim;
        protected string _nama;
        protected string _jeniskelamin;
        protected string _kelas;
        protected string _alamat;
        #endregion
        #region Constructors
        public Mhs() { }
        public Mhs(string nama, string jeniskelamin, string kelas, string alamat)
        {
            this._nama=nama;
            this._jeniskelamin=jeniskelamin;
            this._kelas=kelas;
            this._alamat=alamat;
        }
        #endregion
        #region Public Properties
        public virtual int Nim
        {
            get {return _nim;}
            set {_nim=value;}
        }
        public virtual string Nama
        {
            get {return _nama;}
            set {_nama=value;}
        }
        public virtual string Jeniskelamin
        {
            get {return _jeniskelamin;}
            set {_jeniskelamin=value;}
        }
        public virtual string Kelas
        {
            get {return _kelas;}
            set {_kelas=value;}
        }
        public virtual string Alamat
        {
            get {return _alamat;}
            set {_alamat=value;}
        }
        #endregion
    }
    #endregion
}