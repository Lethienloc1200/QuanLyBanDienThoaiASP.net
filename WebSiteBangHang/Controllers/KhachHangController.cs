using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBangHang.Models;//gọi using model
using System.Web.Security;

namespace WebSiteBangHang.Controllers
{
    [Authorize(Roles = "QuanTri")]  
    public class KhachHangController : Controller
    {
       
        // GET: KhachHang
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        //[Authorize(Roles = "QuanLySanPham")]  //Phân QUYỀN

        public ActionResult Index()
        {
            //tao một lisst danh sach khach hang
            // truy vấn dữ liệu thông qua câu lệnh
            //đổi list sẽ lấy toàn bộ dữ liệu khách hàng
            ///////////cách 1:
            // var lstKH = from KH in db.KhachHangs select KH;
            //Cách 2 dùng phương thức hỗ trợ sẵn
            var lstKH = db.KhachHangs;
            return View(lstKH);
        }
           //ví dụ cách 1
                    public ActionResult View()
                    {
                        //taoj mootj lisst danh sach khach hang
                        var lstKH = from KH in db.KhachHangs select KH;
                        return View(lstKH);
                    }
        
    }
}