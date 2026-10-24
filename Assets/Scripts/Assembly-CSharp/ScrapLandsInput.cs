using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class ScrapLandsInput : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	public struct PlayerActions
	{
		private ScrapLandsInput m_Wrapper;

		public InputAction Move => null;

		public InputAction Look => null;

		public InputAction Fire => null;

		public InputAction Fire2 => null;

		public InputAction Dash => null;

		public bool enabled => false;

		public PlayerActions(ScrapLandsInput wrapper)
		{
			m_Wrapper = null;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(PlayerActions set)
		{
			return null;
		}

		public void AddCallbacks(IPlayerActions instance)
		{
		}

		private void UnregisterCallbacks(IPlayerActions instance)
		{
		}

		public void RemoveCallbacks(IPlayerActions instance)
		{
		}

		public void SetCallbacks(IPlayerActions instance)
		{
		}
	}

	public struct UIActions
	{
		private ScrapLandsInput m_Wrapper;

		public InputAction Navigate => null;

		public InputAction Submit => null;

		public InputAction Cancel => null;

		public InputAction Point => null;

		public InputAction Click => null;

		public InputAction ScrollWheel => null;

		public InputAction MiddleClick => null;

		public InputAction RightClick => null;

		public InputAction TrackedDevicePosition => null;

		public InputAction TrackedDeviceOrientation => null;

		public bool enabled => false;

		public UIActions(ScrapLandsInput wrapper)
		{
			m_Wrapper = null;
		}

		public InputActionMap Get()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public static implicit operator InputActionMap(UIActions set)
		{
			return null;
		}

		public void AddCallbacks(IUIActions instance)
		{
		}

		private void UnregisterCallbacks(IUIActions instance)
		{
		}

		public void RemoveCallbacks(IUIActions instance)
		{
		}

		public void SetCallbacks(IUIActions instance)
		{
		}
	}

	public interface IPlayerActions
	{
		void OnMove(InputAction.CallbackContext context);

		void OnLook(InputAction.CallbackContext context);

		void OnFire(InputAction.CallbackContext context);

		void OnFire2(InputAction.CallbackContext context);

		void OnDash(InputAction.CallbackContext context);
	}

	public interface IUIActions
	{
		void OnNavigate(InputAction.CallbackContext context);

		void OnSubmit(InputAction.CallbackContext context);

		void OnCancel(InputAction.CallbackContext context);

		void OnPoint(InputAction.CallbackContext context);

		void OnClick(InputAction.CallbackContext context);

		void OnScrollWheel(InputAction.CallbackContext context);

		void OnMiddleClick(InputAction.CallbackContext context);

		void OnRightClick(InputAction.CallbackContext context);

		void OnTrackedDevicePosition(InputAction.CallbackContext context);

		void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
	}

	private readonly InputActionMap m_Player;

	private List<IPlayerActions> m_PlayerActionsCallbackInterfaces;

	private readonly InputAction m_Player_Move;

	private readonly InputAction m_Player_Look;

	private readonly InputAction m_Player_Fire;

	private readonly InputAction m_Player_Fire2;

	private readonly InputAction m_Player_Dash;

	private readonly InputActionMap m_UI;

	private List<IUIActions> m_UIActionsCallbackInterfaces;

	private readonly InputAction m_UI_Navigate;

	private readonly InputAction m_UI_Submit;

	private readonly InputAction m_UI_Cancel;

	private readonly InputAction m_UI_Point;

	private readonly InputAction m_UI_Click;

	private readonly InputAction m_UI_ScrollWheel;

	private readonly InputAction m_UI_MiddleClick;

	private readonly InputAction m_UI_RightClick;

	private readonly InputAction m_UI_TrackedDevicePosition;

	private readonly InputAction m_UI_TrackedDeviceOrientation;

	private int m_KeyboardMouseSchemeIndex;

	private int m_GamepadSchemeIndex;

	private int m_TouchSchemeIndex;

	private int m_JoystickSchemeIndex;

	private int m_XRSchemeIndex;

	public InputActionAsset asset { get; }

	public InputBinding? bindingMask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputDevice>? devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ReadOnlyArray<InputControlScheme> controlSchemes => default;

	public IEnumerable<InputBinding> bindings => null;

	public PlayerActions Player => default;

	public UIActions UI => default;

	public InputControlScheme KeyboardMouseScheme => default;

	public InputControlScheme GamepadScheme => default;

	public InputControlScheme TouchScheme => default;

	public InputControlScheme JoystickScheme => default;

	public InputControlScheme XRScheme => default;

	~ScrapLandsInput()
	{
	}

	public void Dispose()
	{
	}

	public bool Contains(InputAction action)
	{
		return false;
	}

	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public void Enable()
	{
	}

	public void Disable()
	{
	}

	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		action = null;
		return 0;
	}
}
