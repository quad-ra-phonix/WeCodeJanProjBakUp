/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_list.h                                          :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/17 13:35:42 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/17 13:42:39 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef __FT_LIST_H__
#define __FT_LIST_H__

typedef struct		s_list
{
	struct s_list	*next;
	void		*data;
}		t_list;

t_list		*ft_create_elem(void *data);

#endif
