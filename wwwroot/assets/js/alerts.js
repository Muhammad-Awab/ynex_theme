setTimeout(() => {
	const alertPlaceholder = document.getElementById('liveAlertPlaceholder')
	const appendAlert = (message, type) => {
	  const wrapper = document.createElement('div')
	  wrapper.innerHTML = [
		`<div class="alert alert-${type} alert-dismissible mt-2" role="alert">`,
		`   <div>${message}</div>`,
		'   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
		'</div>'
	  ].join('')
	
	  alertPlaceholder.append(wrapper)
	}
	
	const alertTrigger = document.getElementById('liveAlertBtn')
	if (alertTrigger) {
	  alertTrigger.onclick = () => {
		appendAlert('Nice, you triggered this alert message!', 'success')
	  }
	}

	
}, 1000);