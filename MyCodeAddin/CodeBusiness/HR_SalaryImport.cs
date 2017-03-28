using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryImport))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryImport:ReadOnlyBase<HR_SalaryImport>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryCode
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string ModeCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public bool IsApprove
        {
            get ;
            set ;
        }

		
        public bool IsConf
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public bool IsHaveTax
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

		public static HR_SalaryImport Create()
        {
            return EF.DataPortal.Create<HR_SalaryImport>();
        }

		public static HR_SalaryImport Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryImport, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryImport>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryImport>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryImports))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryImports:ReadOnlyListBase<HR_SalaryImports,HR_SalaryImport>
    {
        #region Factory Methods

        public static HR_SalaryImports Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryImports>();
        }

		public static HR_SalaryImports Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryImport, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryImport>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryImports>(lambda);
		}

		public static HR_SalaryImports Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryImports>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryImports Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryImport, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryImports>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryImport>(exp,values)});
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
