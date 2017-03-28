using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EQ_Equipment))]
#if Dev
    [RunLocal]
#endif

	public class EQ_Equipment:ReadOnlyBase<EQ_Equipment>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EquCode
        {
            get ;
            set ;
        }

		
        public string EquName
        {
            get ;
            set ;
        }

		
        public string EquTypeCode
        {
            get ;
            set ;
        }

		
        public string CorrCode1
        {
            get ;
            set ;
        }

		
        public string CorrCode2
        {
            get ;
            set ;
        }

		
        public string LabNo
        {
            get ;
            set ;
        }

		
        public string AssCode
        {
            get ;
            set ;
        }

		
        public string AssTypeCode
        {
            get ;
            set ;
        }

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
        public decimal? Worth
        {
            get ;
            set ;
        }

		
        public string Suppor
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string ConstructDate
        {
            get ;
            set ;
        }

		
        public string StartTime
        {
            get ;
            set ;
        }

		
        public string Depositary
        {
            get ;
            set ;
        }

		
        public bool FixAssets
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string State
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EQ_Equipment Create()
        {
            return EF.DataPortal.Create<EQ_Equipment>();
        }

		public static EQ_Equipment Fetch(System.Linq.Expressions.Expression<Func<EQ_Equipment, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EQ_Equipment>(exp,values);
            return EF.DataPortal.Fetch<EQ_Equipment>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EQ_Equipments))]
#if Dev
    [RunLocal]
#endif
	
	public class EQ_Equipments:ReadOnlyListBase<EQ_Equipments,EQ_Equipment>
    {
        #region Factory Methods

        public static EQ_Equipments Fetch()
        {
            return EF.DataPortal.Fetch<EQ_Equipments>();
        }

		public static EQ_Equipments Fetch(System.Linq.Expressions.Expression<Func<EQ_Equipment, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EQ_Equipment>(exp,values);
            return EF.DataPortal.Fetch<EQ_Equipments>(lambda);
		}

		public static EQ_Equipments Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EQ_Equipments>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EQ_Equipments Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EQ_Equipment, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EQ_Equipments>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EQ_Equipment>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
