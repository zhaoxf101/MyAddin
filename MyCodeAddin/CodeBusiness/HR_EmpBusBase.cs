using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusBase))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusBase:ReadOnlyBase<HR_EmpBusBase>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BusBillNo
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string EmpName
        {
            get ;
            set ;
        }

		
        public string IdType
        {
            get ;
            set ;
        }

		
        public string IdNo
        {
            get ;
            set ;
        }

		
        public string Hometown
        {
            get ;
            set ;
        }

		
        public string Sex
        {
            get ;
            set ;
        }

		
        public string Politics
        {
            get ;
            set ;
        }

		
        public DateTime? Birthday
        {
            get ;
            set ;
        }

		
        public string Country
        {
            get ;
            set ;
        }

		
        public string HomeAddr
        {
            get ;
            set ;
        }

		
        public string Nation
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string WeChatNo
        {
            get ;
            set ;
        }

		
        public string QQNo
        {
            get ;
            set ;
        }

		
        public string ImageUrl
        {
            get ;
            set ;
        }

		
        public bool IsInsReturn
        {
            get ;
            set ;
        }

		
        public bool IsSalReturn
        {
            get ;
            set ;
        }

		
        public string PostTypeCode1
        {
            get ;
            set ;
        }

		
        public string PostTypeCode2
        {
            get ;
            set ;
        }

		
        public string SalaryRangeCode
        {
            get ;
            set ;
        }

		
        public string UsedName
        {
            get ;
            set ;
        }

		
        public string ContactAddress
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpBusBase Create()
        {
            return EF.DataPortal.Create<HR_EmpBusBase>();
        }

		public static HR_EmpBusBase Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusBase, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusBase>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusBase>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusBases))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusBases:ReadOnlyListBase<HR_EmpBusBases,HR_EmpBusBase>
    {
        #region Factory Methods

        public static HR_EmpBusBases Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusBases>();
        }

		public static HR_EmpBusBases Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusBase, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusBase>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusBases>(lambda);
		}

		public static HR_EmpBusBases Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusBases>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusBases Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusBase, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusBases>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusBase>(exp,values)});
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
