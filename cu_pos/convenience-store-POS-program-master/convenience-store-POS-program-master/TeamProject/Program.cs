using System;
using System.Collections.Generic;
using System.Windows.Forms;

/// <summary>
///              [ 프로그램 모듈 설명입니다 ]
///                
///            (0)Product.cs: 판매 상품을 저장하는 객체입니다.
///            (1)Pay.cs    : 결제 내역을 저장하는 객체입니다.
///            (2)DB.cs     : 서버DB와의 질의 전달 및 불러온 데이터를 처리합니다.
///            (3)Form1.cs  : 초기화면, 판매/상품관리/매출관리 화면을 각각 띄울 수 있습니다.
///            (4)main.cs   : 판매화면
///                1)pay_cashform.cs : 판매창에서 현금결제 클릭 시 생성되는 화면 및 이벤트를 구현합니다.
///                2)refund.cs       : 판매창에서 환불 클릭 시 생성되는 화면 및 이벤트를 구현합니다.
///            (5)manage1.cs: 상품관리화면
///                1)ProductAdd.cs   : 상품관리창에서 상품추가 클릭 시 생성되는 화면 및 이벤트를 구현합니다.
///                2)ProductDel.cs   : 상품관리창에서 상품변경 클릭 시 생성되는 화면 및 이벤트를 구현합니다.
///            (6)manage2.cs: 매출조회화면
///                1)month_print.cs  : 매출조회창에서 월별조회 클릭 시 생성되는 화면 및 이벤트를 구현합니다.
///                2)day_print.cs    : 매출조회창에서 일별조회 클릭 시 생성되는 화면 및 이벤트를 구현합니다.
///                3)detail_print.cs : 월별/일별 조회 창에서 상세조회 클릭 시 생성되는 화면을 구현합니다.
///                     
/// </summary>
namespace TeamProject
{
    public delegate void DataPushEventHandler(Object obj);                        //자식 폼으로 정보를 보내는 이벤트 구현 핸들러
    public delegate void DataGetEventHandler(Object obj, EventArgs args);         //부모폼으로 정보를 보내는 이벤트 구현 핸들러
   
    static class Program
    {
        


        [STAThread]
        static void Main()
        {
            Pay.MakePaynum();                                       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());          
        }
    }





}
