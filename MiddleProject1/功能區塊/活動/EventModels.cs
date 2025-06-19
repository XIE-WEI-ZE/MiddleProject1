using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleProject1.功能區塊.活動
{

    public class EventModel
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Organizer { get; set; }
        public string TargetAudience { get; set; }
        public bool RequiresFamilyInsurance { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public int ContactPersonID { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPhone { get; set; }
        public string EventLocation { get; set; }
        
        public int? Quota { get; set; }
        public string Description { get; set; }
        public string MedicalAid { get; set; }
        public bool IsPaid { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class EventBatchModel
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public int BatchID { get; set; }
        public DateTime EventDateTimeStar { get; set; }
        public DateTime EventDateTimeEnd { get; set; }
        public DateTime RegistrationDateStar { get; set; }
        public DateTime RegistrationDateEnd { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string Recurrence { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }
    }

    public class RegistrationDetailModel
    {
        public int RegistrationID { get; set; }
        public int EventBatchID { get; set; }
        public string EventName { get; set; }
        public string EventBatchName { get; set; }  // 可為空，請使用時注意 null
        public int MemberID { get; set; }
        public string MemberName { get; set; }    

        public int NumberOfPeople { get; set; }

        public int PaymentStatus { get; set; }
        public string PaymentStatusName { get; set; }

        public decimal? AmountDue { get; set; }     
        public DateTime RegistrationDateTime { get; set; }

        public int CurrentStatus { get; set; }
        public string CurrentStatusName { get; set; }

        public string InternalRemarks { get; set; }

        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }
    }

    public class EventRecordsModel
    {
        public int EventRecordID { get; set; }          // 主鍵：活動紀錄編號（系統自動產生）
        public int BatchID { get; set; }                // 外鍵：活動梯次
        public string Content { get; set; }             // 活動說明與介紹
        public int Status { get; set; }                 // 外鍵：狀態
        public string StatusName { get; set; }
        public string InternalRemarks { get; set; }    // 內部備註（可為 null）
        public DateTime CreatedAt { get; set; }         // 建立日期
        public int CreatedBy { get; set; }              // 外鍵：建立人員
        public DateTime? LastModifiedAt { get; set; }   // 最後修改日期（可為 null）
        public int? LastModifiedBy { get; set; }        // 外鍵：最後修改人員（可為 null）

    }



}




