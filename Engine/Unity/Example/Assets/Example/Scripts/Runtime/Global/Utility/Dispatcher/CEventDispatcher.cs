using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** 이벤트 전달자 */
public class CEventDispatcher : CComponent {
	#region 프로퍼티
	public System.Action<CEventDispatcher, string> AniEventCallback { get; set; } = null;
	#endregion // 프로퍼티

	#region 함수
	/** 애니메이션 이벤트를 수신했을 경우 */
	public void OnReceiveAniEvent(string a_oParams) {
		this.AniEventCallback?.Invoke(this, a_oParams);
	}
	#endregion // 함수
}

