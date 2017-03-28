using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_RDProjSouUnit))]
#if Dev
    [RunLocal]
#endif

	public class PM_RDProjSouUnit:ReadOnlyBase<PM_RDProjSouUnit>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RDProjSouUnitCode
        {
            get ;
            set ;
        }

		
        public string RDProjSouUnitName
        {
            get ;
            set ;
        }

		
        public string PCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static PM_RDProjSouUnit Create()
        {
            return EF.DataPortal.Create<PM_RDProjSouUnit>();
        }

		public static PM_RDProjSouUnit Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjSouUnit, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjSouUnit>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjSouUnit>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_RDProjSouUnits))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_RDProjSouUnits:ReadOnlyListBase<PM_RDProjSouUnits,PM_RDProjSouUnit>
    {
        #region Factory Methods

        public static PM_RDProjSouUnits Fetch()
        {
            return EF.DataPortal.Fetch<PM_RDProjSouUnits>();
        }

		public static PM_RDProjSouUnits Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjSouUnit, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjSouUnit>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjSouUnits>(lambda);
		}

		public static PM_RDProjSouUnits Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_RDProjSouUnits>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_RDProjSouUnits Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_RDProjSouUnit, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_RDProjSouUnits>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_RDProjSouUnit>(exp,values)});
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
