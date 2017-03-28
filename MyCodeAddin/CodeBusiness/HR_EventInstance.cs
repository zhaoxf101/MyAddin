using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventInstance))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventInstance:ReadOnlyBase<HR_EventInstance>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string EventCode
        {
            get ;
            set ;
        }

		
        public string EventValue
        {
            get ;
            set ;
        }

		
        public string Text
        {
            get ;
            set ;
        }

		
        public bool? IsDelete
        {
            get ;
            set ;
        }

		
        public bool? Appovel
        {
            get ;
            set ;
        }

		
        public bool? Cancel
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventInstance Create()
        {
            return EF.DataPortal.Create<HR_EventInstance>();
        }

		public static HR_EventInstance Fetch(System.Linq.Expressions.Expression<Func<HR_EventInstance, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventInstance>(exp,values);
            return EF.DataPortal.Fetch<HR_EventInstance>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventInstances))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventInstances:ReadOnlyListBase<HR_EventInstances,HR_EventInstance>
    {
        #region Factory Methods

        public static HR_EventInstances Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventInstances>();
        }

		public static HR_EventInstances Fetch(System.Linq.Expressions.Expression<Func<HR_EventInstance, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventInstance>(exp,values);
            return EF.DataPortal.Fetch<HR_EventInstances>(lambda);
		}

		public static HR_EventInstances Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventInstances>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventInstances Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventInstance, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventInstances>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventInstance>(exp,values)});
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
