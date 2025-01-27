﻿//using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Share.Models
{
    
    public interface IMonAnSvc
    {
        Task<List<MonAn>> GetMonAnAllAsync();
        List<MonAn> GetMonAnAll();

        MonAn GetMonAn(int id);

        int AddMonAn(MonAn monAn);

        int EditMonAn(int id, MonAn monAn);
        
    }
    public class MonAnSvc : IMonAnSvc
    {
        protected DataContext _context;
        public MonAnSvc(DataContext context)
        {
            _context = context;
        }

        public async Task<List<MonAn>> GetMonAnAllAsync()
        {
            List<MonAn> list = await _context.MonAns.ToListAsync();
            return list;
        }

        public List<MonAn> GetMonAnAll()
        {
            List<MonAn> list = new List<MonAn>();
            list = _context.MonAns.ToList();
            return list;
        }

        public MonAn GetMonAn(int id)
        {
            MonAn monAn = null;
            monAn = _context.MonAns.Find(id); //cách này chỉ dùng cho Khóa chính
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return monAn;
        }

        public int AddMonAn(MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.Add(monAn);
                _context.SaveChanges();
                ret = monAn.MonAnID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditMonAn(int id, MonAn monAn)
        {
            int ret = 0;
            try
            {
                //MonAn _monAn = null;
                //_monAn = _context.MonAns.Find(id); //cách này chỉ dùng cho Khóa chính
                //_monAn.Name = monAn.Name;
                //_monAn.Gia = monAn.Gia;
                //_monAn.Phanloai = monAn.Phanloai;
                //_monAn.Hinh = monAn.Hinh;
                //_monAn.Mota = monAn.Mota;
                //_monAn.Trangthai = monAn.Trangthai;
                //_context.Update(_monAn);

                _context.Update(monAn);
                _context.SaveChanges();
                ret = monAn.MonAnID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
    }   
}